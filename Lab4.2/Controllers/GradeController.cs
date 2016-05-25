using Lab_4_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_4_2.Controllers
{
    public class GradeController : Controller
    {
        // GET: Grade
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _GradeForStudent(int id)
        {
            List<Grade> grades=((Student)Session["Student"]).Grades;
            return PartialView(grades);
        }
        public PartialViewResult _Create(int id)
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _Create(Grade model)
        {
            ((Student)Session["Student"]).Grades.Add(model);
            return RedirectToAction(actionName: "_GradeForStudent",
                routeValues: new { id = 1 });
        }
    }
}