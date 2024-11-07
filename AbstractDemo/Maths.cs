using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public class Maths
    {
        public int add(int x, int y) { return x + y; }
        public int subtract(int x, int y) {return x - y; }
    }
    public class AdvMaths:Maths
    {
        public int multiply(int x, int y) { return x* y; }
        public int divide(int x, int y) { return x / y; }

    }

    public interface ICalculations {
        decimal CalculateSin(double a);
        decimal CalculateCos(double a);
        decimal CalculateTan(double a);


    
    }


    public interface IOtherCalculations {

        decimal ConvertKgToGrams(double kg);
        decimal ConvertGramsToKg(double kg);



    }



    public interface ILengthCalculations : IOtherCalculations {
        decimal inchToCms(double inches);
    
    }

    public  class Calculator : AdvMaths, ICalculations,ILengthCalculations
    {
        public  decimal CalculateCos(double a)
        {
            //throw new NotImplementedException();
            return Convert.ToDecimal(Math.Cos(a));
        }

        public decimal CalculateSin(double a)
        {
            return Convert.ToDecimal(Math.Sin(a));
        }

        public decimal CalculateTan(double a)
        {
            return Convert.ToDecimal(Math.Tan(a));
        }

        public decimal ConvertGramsToKg(double grams)
        {
            decimal kg = (decimal)(grams / 1000);
            return kg;
        }

        public decimal ConvertKgToGrams(double kg)
        {
            decimal grams =(decimal) kg * 1000;
            return grams;
        }

        public decimal inchToCms(double inches)
        {
            //throw new NotImplementedException();
            return 0;
        }
    }

    public class AnotherClass 
    {

        public virtual void M1()
        { 
        
        }
    
    
    }


    public sealed class ClassDemo : AnotherClass {

        public  override void M1() { }


    }


    public class ClassDemo2 : IDisposable
    {
        public void Dispose()
        {
            // throw new NotImplementedException();
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {

            if (disposing)
            {
                Console.WriteLine("Resouces released...");
            }
        }
    }

}
