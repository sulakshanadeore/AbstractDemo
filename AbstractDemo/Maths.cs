using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public class AmazonAsCustomer
    {
        public virtual double CalculateDiscount(int qty, float price, int discount)
        {
            double TotalPrice=qty* price;
            double PriceAfterDiscount=TotalPrice - (TotalPrice * discount / 100);
           return PriceAfterDiscount;
        }
   }
   public class EndCustomer:AmazonAsCustomer
    {
        public override double CalculateDiscount(int qty, float price, int discount)
        {
            double TotalPrice = qty * price;
            double shipping = 100;
            double PriceAfterDiscount = TotalPrice - (TotalPrice * discount / 100) +shipping;
            return PriceAfterDiscount;

        }



    }
}
