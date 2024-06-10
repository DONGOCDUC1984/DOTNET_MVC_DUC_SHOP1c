using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNET_MVC_DUC_SHOP1c.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
       
    }
}
