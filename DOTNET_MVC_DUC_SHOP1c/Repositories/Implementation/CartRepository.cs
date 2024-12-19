using DOTNET_MVC_DUC_SHOP1c.Data;
using DOTNET_MVC_DUC_SHOP1c.Models;
using DOTNET_MVC_DUC_SHOP1c.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Repositories.Implementation
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CartRepository(ApplicationDbContext db, UserManager<IdentityUser> userManager ,
            IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _userManager = userManager;
            _httpContextAccessor=httpContextAccessor;
        }
        // Get Cart of the User
        public async Task<Cart> GetCart()
        {
            var UserId=GetUserId();
            var cart = await _db.Carts
               .Include(x => x.CartItems)
               .ThenInclude(x => x.Product)
               .Where(x => x.UserId == UserId)
               .FirstOrDefaultAsync();
            return cart;
        }
        // Get Cart's length
        public async Task<int> GetCartLength()
        {
            var UserId = GetUserId();
            if (string.IsNullOrEmpty(UserId) )
            {
                return 0;
            }
            var cart = await GetCart();
            if (cart==null)
            {
                return 0;
            }
            var cartItems = await (from x in _db.CartItems
                                   where x.Cart.Id == cart.Id
                                   select x).ToListAsync();
            return cartItems.Count;
        }

        public async Task<double> GetTotalCost()
        {
            var UserId = GetUserId();
            if (string.IsNullOrEmpty(UserId))
            {
                return 0;
            }
            var cart = await GetCart();
            if (cart == null)
            {
                return 0;
            }
            double totalCost = 0.0;
            foreach (var item in cart?.CartItems)
            {
                totalCost += item.Product.Price * item.Quantity;
            }
            return totalCost;
        }
        public async Task<int> AddCartItem(int ProductId)
        {
            try
            {
                var UserId = GetUserId();
                if (string.IsNullOrEmpty(UserId))
                {
                    throw new Exception("User is not logged-in");
                }
                var cart = await GetCart();
                // If a cart is empty
               
                if (cart == null)
                {
                    cart = new Cart()
                    {
                        UserId = GetUserId()
                    };
                    await _db.Carts.AddAsync(cart);
                    await _db.SaveChangesAsync();

                    var newCartItem1 = new CartItem()
                    {
                        Cart = await _db.Carts.FindAsync(cart.Id),
                        Product = await _db.Products.FindAsync(ProductId),
                        Quantity = 1,
                    };
                    await _db.CartItems.AddAsync(newCartItem1);
                    await _db.SaveChangesAsync();
                }
                // If a cart is not empty 
                else
                {
                    var cartItem = await _db.CartItems.Where(x => x.Cart.Id == cart.Id
                         && x.Product.Id == ProductId)
                        .FirstOrDefaultAsync();
                    // if a cartItem is not null
                    if (cartItem != null)
                    {
                        cartItem.Quantity += 1;
                    }
                    // if a cartItem is null
                    else
                    {
                        var newCartItem2 = new CartItem()
                        {
                            Cart = await _db.Carts.FindAsync(cart.Id),
                            Product = await _db.Products.FindAsync(ProductId),
                            Quantity = 1,
                        };
                        await _db.CartItems.AddAsync(newCartItem2);

                    }
                    await _db.SaveChangesAsync();
                }

                return await GetCartLength();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public async Task<bool> RemoveCartItem(int ProductId)
        {
            try
            {
                var cart = await GetCart();
                // If a cart is empty
                if (cart == null)
                {
                    throw new Exception("Cart does not exist");
                }
                else
                {
                    // If a cart is not empty 
                    var cartItem = await _db.CartItems.Where(x => x.Cart.Id == cart.Id
                         && x.Product.Id == ProductId)
                        .FirstOrDefaultAsync();
                    // if a cartItem is not null
                    if (cartItem != null)
                    {
                        _db.CartItems.Remove(cartItem);
                        await _db.SaveChangesAsync();
                    }
                    else
                    {
                        // if a cartItem is null
                        throw new Exception("CartItem does not exist");
                    }
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DecreaseCartItem( int ProductId)
        {
            try
            {
                var cart = await GetCart();
                // If a cart is empty
                if (cart == null)
                {
                    throw new Exception("Cart does not exist");
                }
                // If a cart is not empty 
                else
                {
                    var cartItem = await _db.CartItems.Where(x => x.Cart.Id == cart.Id
                         && x.Product.Id == ProductId)
                        .FirstOrDefaultAsync();
                    // if a cartItem is not null
                    if (cartItem != null)
                    {
                        if (cartItem.Quantity > 1)
                        {
                            cartItem.Quantity -= 1;
                        }
                        else
                        {
                            _db.CartItems.Remove(cartItem);
                            await _db.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        // if a cartItem is null
                        throw new Exception("CartItem does not exist");

                    }
                    await _db.SaveChangesAsync();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private string GetUserId()
        {
            string UserId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            return UserId;
        }

        public async Task<bool> AddOrder(string UserTel, string UserAddress)
        {
            using var transaction = _db.Database.BeginTransaction();
            try
            {
                var cart = await GetCart();
                if (cart == null)
                {
                    throw new Exception("Cart does not exist");
                }
                if (cart.CartItems.Count == 0)
                {
                    throw new Exception("Cart is empty");
                }
                var totalCost = await GetTotalCost();
                var UserId = GetUserId();
                var newOrder = new Order()
                {
                    UserId = UserId,
                    UserTel = UserTel,
                    UserAddress = UserAddress,
                    totalCost = totalCost,
                };
                await _db.Orders.AddAsync(newOrder);
                await _db.SaveChangesAsync();

                foreach (var item in cart.CartItems)
                {
                    var newOrderItem = new OrderItem()
                    {
                        Order = newOrder,
                        Product = item.Product,
                        Quantity = item.Quantity,
                    };
                    await _db.OrderItems.AddAsync(newOrderItem);
                    await _db.SaveChangesAsync();
                }
                _db.CartItems.RemoveRange(cart.CartItems);
                await _db.SaveChangesAsync();
                _db.Carts.Remove(cart);
                await _db.SaveChangesAsync();

                transaction.Commit();
                return true;

            }
            catch (Exception)
            {

                return false; ;
            }


        }
    }
}
