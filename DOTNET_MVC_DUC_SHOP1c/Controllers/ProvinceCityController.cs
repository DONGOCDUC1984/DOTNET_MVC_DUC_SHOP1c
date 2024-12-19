using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Controllers
{
    public class ProvinceCityController : Controller
    {
        private readonly IGenericRepos<ProvinceCity> _provinceCityRepos;
       
        public ProvinceCityController(IGenericRepos<ProvinceCity> provinceCityRepos)
        {
            _provinceCityRepos = provinceCityRepos;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetList()
        {
            var data = await _provinceCityRepos.GetList();
            return Json(data);
        }
        public async Task<ProvinceCity> GetById(int id)
        {
            var data = await _provinceCityRepos.GetById(id);
            return data;
        }
        // Add or Update
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUpdate(ProvinceCity provinceCity)
        {
            if (ModelState.IsValid)
            {
                // Add
                if (provinceCity.Id==0)
                {
                    var result = await _provinceCityRepos.Add(provinceCity);
                    if (result)
                    {
                        TempData["success"] = "Province/City was successfullly added";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["error"] = "Error";
                        return RedirectToAction("Index");
                    }
                }
                // Update
                else
                {
                    var result = await _provinceCityRepos.Update(provinceCity);
                    if (result)
                    {
                        TempData["success"] = "Province/City was successfullly updated";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["error"] = "Error";
                        return RedirectToAction("Index");
                    }
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
            var result = await _provinceCityRepos.Delete(id);
            if (result)
            {
                TempData["success"] = "Province/City was successfullly deleted ";
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
