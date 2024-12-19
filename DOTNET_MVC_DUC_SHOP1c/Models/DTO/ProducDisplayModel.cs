using System.Collections.Generic;
using System.Linq;

namespace DOTNET_MVC_DUC_SHOP1c.Models.DTO
{
    public class ProducDisplayModel
    {
        public IQueryable<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public List<ProvinceCity> ProvinceCities { get; set; }
        //public List<District> Districts { get; set; }
        public string searchStr { get; set; }
        public int categoryId { get; set; }
        public int provinceCityId { get; set; }
        public int districtId { get; set; }
        public double minPrice { get; set; }
        public double maxPrice { get; set; }
        public int pageSize { get; set; }
        public int currentPage { get; set; }
        public int totalPages { get; set; }

    }
}
