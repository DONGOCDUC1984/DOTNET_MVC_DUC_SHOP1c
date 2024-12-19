using DOTNET_MVC_DUC_SHOP1c.Data;
using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Models.DTO;
using DOTNET_MVC_DUC_SHOP1c.Redis;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IRedisCacheService _redisCacheService;

        public HomeRepository(ApplicationDbContext db , IRedisCacheService redisCacheService)
        {
            _db = db;
            _redisCacheService = redisCacheService;
        }

        public async Task<List<Category>> GetCategories()
        {
            var data = await _db.Categories.ToListAsync();
            return data ;
        }
        public async Task<List<ProvinceCity>> GetProvinceCities()
        {
            return await _db.ProvinceCities.ToListAsync();

        }
        public async Task<List<District>> GetDistrictByProvinceCityId(int provinceCityId)
        {
            var data= await _db.Districts.Where(x => x.ProvinceCityId == provinceCityId)
                                         .ToListAsync();
            return data;
        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                var product=await _db.Products.FindAsync(id);
                if (product== null)
                {
                    return false;
                }
                else
                {
                    _db.Products.Remove(product);
                }
                _redisCacheService.RemoveData("Product");
                await _db.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
        // Add or Update
        public async Task<bool> AddUpdate(Product product)
        {
            try
            {
                if (product.Id == 0)
                {
                    await _db.Products.AddAsync(product);
                }
                else
                {
                     _db.Products.Update(product);
                }
                _redisCacheService.RemoveData("Product");
                await _db.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public async Task<Product> GetById(int id)
        {
            var list = await GetList("", 0,0,0,0,0);
            var data = list.FirstOrDefault(x => x.Id == id);
            return data;
        }
        public async Task<Product> GetOnlyProductById(int id)
        {
            // In the following line, there shoud be AsNoTracking(),Otherwise,there will be an error
            //  when we utilize this method to delete the image of the old product in Controller
            var data =await _db.Products.AsNoTracking()
                      .FirstOrDefaultAsync(x => x.Id == id);
            return data;
        }

        public IEnumerable<SelectListItem> GetCategoryList()
        {
            IEnumerable<SelectListItem> data =  _db.Categories.Select(x =>
             new SelectListItem 
             {
                 Text=x.Name,
                 Value=x.Id.ToString()
             });
            return data;
        }
        public IEnumerable<SelectListItem> GetProvinceCityList()
        {
            IEnumerable<SelectListItem> data = _db.ProvinceCities.Select(x =>
             new SelectListItem
             {
                 Text = x.Name,
                 Value = x.Id.ToString()
             });
            return data;
        }
        // Without "ref" in the following line,filteredData will not change
        private void Search(ref List<Product> filteredData, string searchStr = "", int categoryId = 0,
            int provinceCityId = 0, int districtId = 0, double minPrice = 0.0, double maxPrice = 0.0)
        {
            searchStr = searchStr?.ToLower();
            if (!string.IsNullOrEmpty(searchStr))
            {
                filteredData = filteredData.Where(x => x.Name.ToLower().Contains(searchStr)
                                               || x.Description.ToLower().Contains(searchStr)

                                               ).ToList();
            }
            if (categoryId > 0)
            {
                filteredData = filteredData.Where(x => x.CategoryId == categoryId).ToList();
            }
            if (provinceCityId > 0)
            {
                filteredData = filteredData.Where(x => x.ProvinceCityId == provinceCityId).ToList();
            }
            if (districtId > 0)
            {
                filteredData = filteredData.Where(x => x.DistrictId == districtId).ToList();
            }
            if (minPrice != 0)
            {
                filteredData = filteredData.Where(x => x.Price >= minPrice).ToList();
            }
            if (maxPrice != 0)
            {
                filteredData = filteredData.Where(x => x.Price <= maxPrice).ToList();
            }
        }
        public async Task<List<Product>> GetList(string searchStr = "", int categoryId = 0,
            int provinceCityId = 0, int districtId = 0, double minPrice = 0.0, double maxPrice = 0.0)
        {
            searchStr = searchStr?.ToLower();
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            var cacheData = _redisCacheService.GetData<List<Product>>("Product");
            var filteredData = cacheData;
            if (cacheData != null)
            {
                Search(ref filteredData, searchStr, categoryId, provinceCityId, districtId, minPrice , maxPrice);
                return filteredData;
            }
            var data = await _db.Products
                                     .Include(x => x.Category)
                                     .Include(x => x.District)
                                     .ThenInclude(x=>x.ProvinceCity)
                                     .OrderBy(x => x.Id)
                                     .ToListAsync();
            _redisCacheService.SetData<List<Product>>("Product", data, expirationTime);
            cacheData = _redisCacheService.GetData<List<Product>>("Product");
            filteredData = cacheData;
            Search(ref filteredData, searchStr, categoryId, provinceCityId, districtId, minPrice, maxPrice);
            return filteredData;
        }

        public async Task<ProducDisplayModel> GetProducDM(string searchStr = "", int categoryId = 0, 
            int provinceCityId = 0, int districtId = 0, double minPrice = 0, 
            double maxPrice = 0, bool paging = false, int currentPage = 0)
        {
            var products= await GetList(searchStr , categoryId ,
            provinceCityId, districtId , minPrice ,  maxPrice);
            var categories = await GetCategories();
            var provinceCities = await GetProvinceCities();
            var productDM = new ProducDisplayModel();
            if (paging)
            {
                int pageSize = 10;
                int count = products.Count();
                int totalPages = (int)Math.Ceiling(count / (double)pageSize);
                products = products.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                productDM.Products = products.AsQueryable();
                productDM.pageSize = pageSize;
                productDM.currentPage = currentPage;
                productDM.totalPages = totalPages;
            }
            productDM.Products = products.AsQueryable();
            productDM.Categories = categories;
            productDM.ProvinceCities = provinceCities;
            productDM.searchStr = searchStr;
            productDM.categoryId = categoryId;
            productDM.provinceCityId = provinceCityId;
            productDM.districtId = districtId;
            productDM.minPrice = minPrice;
            productDM.maxPrice = maxPrice;
            return productDM;

        }

       
    }
}
