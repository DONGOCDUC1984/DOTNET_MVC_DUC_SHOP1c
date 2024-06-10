using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DOTNET_MVC_DUC_SHOP1c.Models
{
    public class ProvinceCity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<District> Districts { get; set; }
    }
}
