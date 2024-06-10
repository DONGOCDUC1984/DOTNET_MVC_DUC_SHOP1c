using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;
        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _cartRepository.GetCart();
            ViewData["TotalCost"] = await GetTotalCost();
            return View(data);
        }
        public async Task<IActionResult> GetCartLength()
        {
            var data = await _cartRepository.GetCartLength();
            return Ok(data);
        }
        public async Task<double> GetTotalCost()
        {
            var data = await _cartRepository.GetTotalCost();
            return data;
        }
        public async Task<IActionResult> AddCartItem(int ProductId,int redirect=0)
        {
            var CartLength = await _cartRepository.AddCartItem(ProductId);
            if (redirect==0)
            {
                return Ok(CartLength);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveCartItem(int ProductId)
        {
            await _cartRepository.RemoveCartItem(ProductId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DecreaseCartItem(int ProductId)
        {
            await _cartRepository.DecreaseCartItem(ProductId);
            return RedirectToAction("Index");
        }
        // Order
        public async Task<IActionResult> AddOrder(string UserTel, string UserAddress)
        {
            var result = await _cartRepository.AddOrder(UserTel,UserAddress);
            if (result)
            {
                TempData["success"] = "Order was successfullly saved";
            }
            // Redirect to Home/Index
            return RedirectToAction("Index", "Home");
        }
    }
}
