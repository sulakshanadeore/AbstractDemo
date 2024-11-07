using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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



    public class AssociateSeller : AmazonAsCustomer
    {
        public new double CalculateDiscount(int qty, float price, int discount)
        {
            int advtcharges = 1000;
            int reelcharges = 100;
          double totalprice=(qty * price) + ((qty * price) - discount / 100) + advtcharges + reelcharges;
        return totalprice;
        }
     }


    public class WhatsAppGroupForSelling:AssociateSeller
    {
        public new double CalculateDiscount(int qty, float price, int discount) 
        {
            return base.CalculateDiscount(qty, price, discount) + 10;
        }

    }


   public class EndCustomer:AmazonAsCustomer
    {
        public override double CalculateDiscount(int qty, float price, int discount)
        {
         
            double shipping = 100;
            double PriceAfterDiscount = base.CalculateDiscount(qty,price,discount) +shipping;
            return PriceAfterDiscount;

        }
    }
}
