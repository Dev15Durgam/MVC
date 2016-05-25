using Lab_4_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_4_2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {

            Student student = new Student()
            {

                StudentID = 1,
                StudentName = "Jason",
                StudentLastname = "Litzo",
                StudentPN = 010101 - 0304,
                StudentAddress = "CoolStreet",
                Grades = new List<Grade>()
                {
                    new Grade() { GradeID=1, CourseName="Fysik 1",StudentGrade='B'},
                    new Grade() {GradeID=2, CourseName="Biologi 2",StudentGrade='A' }

                }
            };
            Session["Student"] = student;
            return View(student);
        }
    }
}