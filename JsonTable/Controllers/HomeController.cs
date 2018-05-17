using JsonTable.Clients.Mappers;
using JsonTable.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace JsonTable.Controllers
{
    public class HomeController : Controller
    {

        private IStockService stockService;
        private IStockClientMapper clientStockMapper;
        
        public HomeController(IStockService stockService, IStockClientMapper clientStockMapper)
        {
            this.stockService = stockService;
            this.clientStockMapper = clientStockMapper;
        }

        public async Task<ActionResult> Index()
        {
            return View(clientStockMapper.Map(await stockService.GetStocks()));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}