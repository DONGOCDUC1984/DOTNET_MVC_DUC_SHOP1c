using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace DOTNET_MVC_DUC_SHOP1c.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        [Required]
        public string UserTel { get; set; }
        [Required]
        public string UserAddress { get; set; }
        public double totalCost { get; set; }
    }
}
