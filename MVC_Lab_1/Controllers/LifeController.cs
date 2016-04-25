using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Lab_1.Controllers
{
    public class LifeController : Controller
    {
        // GET: Life
        public ActionResult SuperMario()
        {
            return View();
        }
        public ActionResult Health()
        {
            return View();
        }
        public ActionResult Live(int id)
        {
            if (id != null)
                ViewBag.Quantity = id;
            else
                ViewBag.Quantity = "none";
            return View();
        }

    }
}