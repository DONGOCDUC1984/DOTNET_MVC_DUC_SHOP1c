using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IGenericRepository<District> _districtRepository;
        private readonly IGenericRepos<ProvinceCity> _provinceCityRepos;
        public DistrictController(IGenericRepository<District> districtRepository,
           IGenericRepos<ProvinceCity> provinceCityRepos
            )
        {
            _districtRepository = districtRepository;
            _provinceCityRepos = provinceCityRepos;
        }
        public async Task<IActionResult> Index()
        {
            var data= await _districtRepository.GetList(); 
            return View(data);
           
        }

        public async Task<IActionResult> GetList()
        {
            var data = await _districtRepository.GetList();
            return Json(data);
        }
        public async Task<IActionResult> GetProvinceCityList()
        {
            var data = await _provinceCityRepos.GetList();
            return Json(data);
        }
        public async Task<District> GetById(int id)
        {
            var data = await _districtRepository.GetById(id);
            return data;
        }
        // Add or Update
        public async Task<IActionResult> AddUpdate(int id)
        {
            var list = await _provinceCityRepos.GetList();
           IEnumerable <SelectListItem> provinceCityList = list
                .Select(x =>
              new SelectListItem
              {
                  Text = x.Name,
                  Value = x.Id.ToString(),
              }
            );
            
            ViewBag.provinceCityList = provinceCityList;

            // Add
            if (id == 0)
            {
                ViewData["Title"] = "Create";
                return View();
            }
            // Update
            else
            {
                var district = await _districtRepository.GetById(id);
                if (district == null)
                {
                    return NotFound();
                }
                ViewData["Title"] = "Update";
                return View(district);
            }

        }
        // Add or Update
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUpdate(District district)
        {
            if (ModelState.IsValid)
            {
                var result= await _districtRepository.AddUpdate(district);
                if (result)
                {
                    TempData["success"] = "District was successfullly saved";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["error"] = "Error";
                    return View(district);
                }
                
            }
            TempData["error"] = "Error";
            return View(district);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                TempData["error"] = "Error";
                return RedirectToAction("Index");
            }
            var result = await _districtRepository.Delete(id);
            if (result)
            {
                TempData["success"] = "District was successfullly deleted ";
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
