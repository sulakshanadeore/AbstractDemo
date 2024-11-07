using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public class SecondaryStudent : Student,ICalculate
    {
        private double perc;
        public override double Percentage 
        { 
            get 
            {
                return perc;
            } 
            set 
            { 
                perc = value; 
            }
        }

        private double p;
        public double ShowPercentage { get { return p; } private set { p = value; } }

        public override void CalculatePercentage(double marks, double subjectCount)
        {

            double a=(marks / subjectCount) * 100;
            Percentage = a;
            //(marks / subjectCount) * 100;
            ShowPercentage = Percentage;
        }

        public double CalculateTotalMArks(int sub1, int sub2, int sub3, int sub4)
        {
            //throw new NotImplementedException();
            double totalMArks = 0;
            totalMArks = sub1 + sub1 + sub3 + sub4;
            return totalMArks;
        }
    }
}
