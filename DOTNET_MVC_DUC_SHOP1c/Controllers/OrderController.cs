using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IGenericRepository<Order> _orderRepository;
        public OrderController(IGenericRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _orderRepository.GetList();
            return View(data);
        }

        public async Task<IActionResult> PDFFile()
        {
            var data = await _orderRepository.GetList();
            return new ViewAsPdf(data);
        }
        public async Task<Order> GetById(int id)
        {
            var data = await _orderRepository.GetById(id);
            return data;
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                TempData["error"] = "Error";
                return RedirectToAction("Index");
            }
            var result = await _orderRepository.Delete(id);
            if (result)
            {
                TempData["success"] = "Order was successfullly deleted ";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Error";
                return RedirectToAction("Index");
            }
        }
        
        public async Task<IActionResult> GetListByUserId()
        {
            var data = await _orderRepository.GetListByUserId();
            return View(data);
        }

    }
}
