using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class Program
    {
        static int? CalculateAge(DateTime dt)
        {
            int? age = null;
            int y=dt.Year;
            if (y >= 1900 && y <= 2100)
            {
                age = DateTime.Now.Year - dt.Year;
            }
            return age;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr date");
           DateTime dt =Convert.ToDateTime(Console.ReadLine());    
            int? age=CalculateAge(dt);
            if (!age.HasValue) {
                Console.WriteLine("Null age");
            }
            else
            Console.WriteLine(age);
           // int i = null;//Value types cannot be assigned a null
            //Nullable<int> p= null;  
            //int? r= null;   











            //var i = 10;//cannot be used as a parameter in the method
            //dynamic can be used as parameter in  a method
            




            //AmazonAsCustomer customer = new AmazonAsCustomer();
            //double PriceForAmazon=customer.CalculateDiscount(100, 200, 10);
            //Console.WriteLine($"Price for Amazon :  {PriceForAmazon}");

            //EndCustomer we = new EndCustomer();
            //double PriceForUs=we.CalculateDiscount(100, 210, 2);

            //Console.WriteLine($"Price for PriceForUs :  {PriceForUs}"); 

            //AssociateSeller associate=new AssociateSeller();
            //double PriceForAssociate=associate.CalculateDiscount(100, 190, 3);
            //Console.WriteLine($"Price for PriceForAssociate :  {PriceForAssociate}");

            //using (ClassDemo2 obj=new ClassDemo2())
            //{
            //    obj.Dispose();

            //}

            //ClassDemo2 obj1=new ClassDemo2();
            //obj1.Dispose();


            //string s = "Everything is fine";

            //string s1= s.Replace('e','$');
            //string final = s1.Replace('E', '$');
            //Console.WriteLine(final);
            
            //IEnumerable<char> reversedString=final.Reverse();
            //foreach (var item in reversedString)
            //{
            //    Console.Write(item);
            //}
            

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
