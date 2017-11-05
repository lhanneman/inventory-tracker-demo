using AuctioneerDemo.Models;
using AuctioneerDemo.Services.Interfaces;
using System.Web.Mvc;

namespace AuctioneerDemo.Controllers
{
    public class HomeController : Controller
    {
        private IEquipmentService equipmentService;

        public HomeController(IEquipmentService equipmentService)
        {
            this.equipmentService = equipmentService;
        }

        public ActionResult Index()
        {
            return View(new EquipmentViewModel() { Equipment = equipmentService.GetAllEquipment() });
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