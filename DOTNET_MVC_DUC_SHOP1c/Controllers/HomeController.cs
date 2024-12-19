using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using ClosedXML.Excel;


namespace DOTNET_MVC_DUC_SHOP1c.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        // For multi-language
        private readonly IHtmlLocalizer<HomeController> _localizer;

        public HomeController(ILogger<HomeController> logger ,
           IHomeRepository homeRepository , 
           IWebHostEnvironment webHostEnvironment,
            IHtmlLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _homeRepository = homeRepository;
            _webHostEnvironment = webHostEnvironment;
            _localizer = localizer;
        }
        // for multi-language
        [HttpPost]
        public IActionResult CultureManage(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider
                .MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddYears(1) }
            );
            return LocalRedirect(returnUrl);
        }
        public async Task<IActionResult> Index(string searchStr = "", int categoryId = 0,
            int provinceCityId = 0, int districtId = 0, double minPrice = 0,
            double maxPrice = 0, bool paging = true, int currentPage = 1)
        {
            var productDM = await _homeRepository.GetProducDM(searchStr, categoryId ,
            provinceCityId , districtId , minPrice , maxPrice , paging , currentPage );
            return View(productDM);
        }
       
        public async Task<IActionResult> Details(int id)
        {
            var data = await _homeRepository.GetById(id);
            return View(data);
        }
        // Add or Update
        public async Task<IActionResult> AddUpdate(int id)
        {
            var categoryList = _homeRepository.GetCategoryList();
            var provinceCityList = _homeRepository.GetProvinceCityList();
            ViewBag.categoryList = categoryList;
            ViewBag.provinceCityList = provinceCityList;

            // Add
            if (id==0)
            {
                ViewData["Title"] = "Create";
                return View();
            }
            // Update
            else
            {
                var product =await _homeRepository.GetById(id);
                if (product == null)
                {
                    return NotFound();
                }
                ViewData["Title"] = "Update";
                return View(product);
            }

        }

        // Add or Update
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUpdate(Product product ,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = DateTime.Now.ToString("yymmssfff") + "-" + file.FileName;
                    string productPath = Path.Combine(wwwRootPath, @"images\product");
                    // delete the old image
                    if (product.Id > 0)
                    {
                        // Without the following line,product.ImageUrl= null and
                        // the old image will not be deleted 
                        var oldProduct = await _homeRepository.GetOnlyProductById(product.Id);
                        if (!string.IsNullOrEmpty(oldProduct.ImageUrl))
                        {
                            string oldImagePath =
                                Path.Combine(wwwRootPath, oldProduct.ImageUrl.TrimStart('\\'));
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }
                    }
                    // Create new product.ImageUrl
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), 
                        FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    product.ImageUrl = @"\images\product\" + fileName;
                }
               
                var result = await _homeRepository.AddUpdate(product);
                if (result)
                {
                    TempData["success"] = "Product was successfullly saved";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["error"] = "Error";
                    return View(product);
                }
               
            }
            TempData["error"] = "Error";
            return View(product);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _homeRepository.GetById(id);
            // delete the old image
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            if (!string.IsNullOrEmpty(product.ImageUrl))
            {

                string oldImagePath =
                    Path.Combine(wwwRootPath, product.ImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            //delete the product
            var result = await _homeRepository.Delete(id);
            if (result)
            {
                TempData["success"] = "Product was successfullly deleted ";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Error";
                return RedirectToAction("Index");
            }
        }
        // Get districs by ProvinceCityId
        public async Task<IActionResult> GetDistrictByProvinceCityId(int provinceCityId)
        {
            var data = await _homeRepository.GetDistrictByProvinceCityId(provinceCityId);
            return Json(data);
        }

        // Export to an Excel file
        public async Task<FileResult> ExportToExcel()
        {
            var products = await _homeRepository.GetList();
            var fileName = "Products.xlsx";
            return GenerateExcel(fileName, products);
        }
        private FileResult GenerateExcel(string fileName, List<Product> products)
        {
            var dataTable = new System.Data.DataTable("Products");

            dataTable.Columns.AddRange(new System.Data.DataColumn[]
            {
                new System.Data.DataColumn("Id"),
                new System.Data.DataColumn("Name"),
                new System.Data.DataColumn("Description"),
                new System.Data.DataColumn("Price ($)"),
                new System.Data.DataColumn("Category"),
                new System.Data.DataColumn("Province/City"),
                new System.Data.DataColumn("District"),
            });
            foreach (var item in products)
            {
                dataTable.Rows.Add(item.Id, item.Name, item.Description,item.Price, 
                    item.Category.Name, item.District.ProvinceCity.Name , item.District.Name);
            }
            using (var wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dataTable);
                using (var stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        fileName);
                }
            }
        }
        // End for excel
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
