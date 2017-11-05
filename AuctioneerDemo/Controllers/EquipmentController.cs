using AuctioneerDemo.Entities;
using AuctioneerDemo.Services.Interfaces;
using System.Web.Mvc;

namespace AuctioneerDemo.Controllers
{
    public class EquipmentController : Controller
    {
        private IEquipmentService equipmentService;

        public EquipmentController(IEquipmentService equipmentService)
        {
            this.equipmentService = equipmentService;
        }

        public ActionResult Index(int id)
        {
            var equipment = equipmentService.GetEquipment(id);

            if (equipment == null)
            {
                equipment = new Equipment();
            }

            return View(equipment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOrUpdate(Equipment equipment)
        {
            equipmentService.AddUpdateEquipment(equipment);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {

            if (id <= 0)
            {
                return new HttpNotFoundResult();
            }

            var equipment = equipmentService.GetEquipment(id);

            if (equipment == null)
            {
                return new HttpNotFoundResult();
            }

            return View(equipment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(Equipment equipment)
        {
            if (equipment.EquipmentId <= 0)
            {
                return new HttpNotFoundResult();
            }

            equipmentService.DeleteEquipment(equipment);

            return RedirectToAction("Index", "Home");
        }
    }
}