using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Parking.Controllers
{
    public class FlashParkController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ParkingLots = new SelectList(new List<SelectListItem>
                 {
                    new SelectListItem { Selected = false, Text = "Lot 1", Value = "1"},
                    new SelectListItem { Selected = false, Text = "Lot 2", Value = "2"},
                    new SelectListItem { Selected = false, Text = "Lot 3", Value = "3"},
                 }, "Value", "Text", 1);
            return View();
        }
    }
}