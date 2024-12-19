using DOTNET_MVC_DUC_SHOP1c.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DOTNET_MVC_DUC_SHOP1c.Controllers
{
    public class AnnualProfitController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AnnualProfitController(ApplicationDbContext db)
        {
           _db=db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProfitChart()
        {
            return View();
        }
        public List<object> GetProfitData()
        {
            var data = new List<object>();
            var labels = _db.AnnualProfits.Select(x => x.Month).ToList();
            var MonthlyProfit = _db.AnnualProfits.Select(x => x.MonthlyProfit).ToList();
            data.Add(labels);
            data.Add(MonthlyProfit);
            return data;
        }
    }
}
