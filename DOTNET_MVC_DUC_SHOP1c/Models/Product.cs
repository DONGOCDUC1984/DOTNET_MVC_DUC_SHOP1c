using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNET_MVC_DUC_SHOP1c.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        public List<OrderItem> OrderItem { get; set; }
        public List<CartItem> CartItem { get; set; }
        public int ProvinceCityId { get; set; }
        public int DistrictId { get; set; }
        [ValidateNever]
        public District District { get; set; }
        public string ImageUrl { get; set; }

    }
}
