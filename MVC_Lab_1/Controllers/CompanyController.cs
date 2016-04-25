using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Lab_1.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EcUtbildning()
        {
            return View();
        }
        public ActionResult Ericsson()
        {
            return View();
        }
        public ActionResult Volvo()
        {
            return View();
        }
    }
}