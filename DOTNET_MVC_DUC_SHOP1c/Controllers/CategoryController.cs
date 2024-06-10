using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IGenericRepository<Category> _categoryRepository;
        public CategoryController(IGenericRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;    
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetList()
        {
            var data = await _categoryRepository.GetList();
            return Json(data);
        }
        public async Task<Category>  GetById(int id)
        {
            var data = await _categoryRepository.GetById(id);
            return data;
        }
        // Add or Update
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUpdate(Category category)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryRepository.AddUpdate(category);
                if (result)
                {
                    TempData["success"] = "Category was successfullly saved";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["error"] = "Error";
                    return RedirectToAction("Index");
                }

            }
            TempData["error"] = "Error";
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                TempData["error"] = "Error";
                return RedirectToAction("Index");
            }
            var result = await _categoryRepository.Delete(id);
            if (result)
            {
                TempData["success"] = "Category was successfullly deleted ";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Error";
                return RedirectToAction("Index");
            }
        }
    }
}
