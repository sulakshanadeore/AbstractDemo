using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AmazonAsCustomer customer = new AmazonAsCustomer();
            double PriceForAmazon=customer.CalculateDiscount(100, 200, 10);
            Console.WriteLine($"Price for Amazon :  {PriceForAmazon}");

            EndCustomer we = new EndCustomer();
            double PriceForUs=we.CalculateDiscount(100, 210, 2);

            Console.WriteLine($"Price for PriceForUs :  {PriceForUs}"); 

            AssociateSeller associate=new AssociateSeller();
            double PriceForAssociate=associate.CalculateDiscount(100, 190, 3);
            Console.WriteLine($"Price for PriceForAssociate :  {PriceForAssociate}");

            using (ClassDemo2 obj=new ClassDemo2())
            {
                obj.Dispose();

            }

            ClassDemo2 obj1=new ClassDemo2();
            obj1.Dispose();
                    

            //SecondaryStudent s=new SecondaryStudent();
            //Console.WriteLine("Enter rollno");
            //s.Rollno = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name");
            //s.Studname = Console.ReadLine();
            //Console.WriteLine("Enter age");
            //s.Age = Convert.ToInt32(Console.ReadLine());

            //double total=s.CalculateTotalMArks(13, 45, 67, 89);
            //s.CalculatePercentage(total, 100);
            //Console.WriteLine(s.ShowPercentage);
            Console.ReadLine();
        }
    }
}
