using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inghram_MIS_4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is data for Brooke.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact info for Brooke";

            return View();
        }
    }
}