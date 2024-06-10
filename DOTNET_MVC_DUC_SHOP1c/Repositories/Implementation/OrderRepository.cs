using DOTNET_MVC_DUC_SHOP1c.Data;
using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation
{
    public class OrderRepository : IGenericRepository<Order>
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public OrderRepository(ApplicationDbContext db , UserManager<IdentityUser> userManager,
            IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        // Get List of Orders
        public async Task<List<Order>> GetList()
        {
            var data = await _db.Orders
               .Include(x => x.OrderItems)
               .ThenInclude(x => x.Product)
               .ToListAsync();
            return data;
        }
        public async Task<bool> AddUpdate(Order t)
        {
            throw new System.NotImplementedException();
        }
        // Delete Order
        public async Task<bool> Delete(int id)
        {
            try
            {
                var data = await GetById(id);
                if (data == null)
                { return false; }

                _db.Orders.Remove(data);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // Get Order by Id
        public async Task<Order> GetById(int id)
        {
            return await _db.Orders.FindAsync(id);
        }
        // Get list of Orders by UserId
        public async Task<List<Order>> GetListByUserId()
        {
            var UserId = GetUserId();
            var data = await _db.Orders
                .Include(x => x.OrderItems)
                .ThenInclude(x => x.Product)
                .Where(x => x.UserId == UserId)
                .ToListAsync();
            return data;
        }
        private string GetUserId()
        {
            string UserId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            return UserId;
        }
    }
}
