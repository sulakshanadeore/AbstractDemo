using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public abstract class Student
    {
        public int Rollno { get; set; }
        public string Studname { get; set; }
        public int Age { get; set; }

        public abstract double Percentage { get;  set; }
        public abstract void CalculatePercentage(double marks, double subjectCount);
       
    }
}
