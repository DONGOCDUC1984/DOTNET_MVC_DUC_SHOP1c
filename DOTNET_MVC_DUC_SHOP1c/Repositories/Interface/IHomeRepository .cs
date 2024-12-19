using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Models.DTO;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Repositories.Interface
{
    public interface IHomeRepository
    {
        Task<List<Product>> GetList(string searchStr = "",
            int categoryId = 0, int provinceCityId = 0, int districtId = 0,
            double minPrice = 0.0, double maxPrice = 0.0);
        Task<ProducDisplayModel> GetProducDM(string searchStr = "",
            int categoryId = 0, int provinceCityId = 0, int districtId = 0,
            double minPrice = 0.0, double maxPrice = 0.0 ,
            bool paging=false,int currentPage=0);
        Task<List<Category>> GetCategories();
        Task<List<District>> GetDistrictByProvinceCityId(int provinceCityId);
        Task<Product> GetById(int id);
        Task<Product> GetOnlyProductById(int id);

        IEnumerable<SelectListItem> GetCategoryList();
        IEnumerable<SelectListItem> GetProvinceCityList();
        //IEnumerable<SelectListItem> GetDistrictList();
        Task<bool> AddUpdate(Product product);
        
        Task<bool> Delete(int id);
    }
}
