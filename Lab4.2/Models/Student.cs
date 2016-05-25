using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_2.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentLastname { get; set; }
        public double StudentPN { get; set; }
        public string StudentAddress { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
