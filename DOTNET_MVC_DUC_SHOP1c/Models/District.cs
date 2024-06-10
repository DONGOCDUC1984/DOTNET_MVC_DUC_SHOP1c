using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOTNET_MVC_DUC_SHOP1c.Models
{
    public class District
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int ProvinceCityId { get; set; }
        [ValidateNever]
        public ProvinceCity ProvinceCity { get; set; }
        [NotMapped]
        public string ProvinceCityName { get; set; }
    }
}
