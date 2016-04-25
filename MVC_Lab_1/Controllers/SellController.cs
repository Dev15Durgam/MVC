using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Lab_1.Controllers
{
    public class SellController : Controller
    {
        // GET: Sell
        public ActionResult B2B()
        {
            return View();
        }
        public ActionResult B2C()
        {
            return View();
        }
        public ActionResult C2C()
        {
            return View();
        }
        public ActionResult Completion()
        {
            return View();
        }
    }
}