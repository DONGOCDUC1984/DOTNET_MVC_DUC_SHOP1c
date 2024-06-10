using DOTNET_MVC_DUC_SHOP1c.Models;
using System.Threading.Tasks;

namespace DOTNET_MVC_DUC_SHOP1c.Repositories.Interface
{
    public interface ICartRepository
    {
        Task<Cart> GetCart();
        Task<int> GetCartLength();
        Task<double> GetTotalCost();
        Task<int> AddCartItem(int ProductId);
        Task<bool> RemoveCartItem(int ProductId);
        Task<bool> DecreaseCartItem(int ProductId);
        Task<bool> AddOrder(string UserTel, string UserAddress);
    }
}
