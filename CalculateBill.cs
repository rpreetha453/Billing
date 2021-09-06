using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
   public class CalculateBill
    {
       List<Calculate> CalculateList;
       public CalculateBill()
       {
           CalculateList = new List<Calculate>();
           Calculate p= new Calculate("Green Tea", 65, 0, 0);
           
           Calculate p1 = new Calculate("Cappuccino", 65, 0, 0);
           Calculate p2 = new Calculate("Cafe Latte", 70, 0, 0);
           Calculate p3 = new Calculate("Hot Chocolate", 65, 0, 0);
           Calculate p4 = new Calculate("Chai", 65, 0, 0);
           
            CalculateList.Add(p);
           CalculateList.Add(p1);
       CalculateList.Add(p2);
       CalculateList.Add(p3);
       CalculateList.Add(p4);
      
       }
       public string Productname(int productno)
       {
           int count = 0;
           foreach (Calculate x in CalculateList)
           {
               if (count == productno)
               {
                   return x.Product;
               }
               count++;
           } return "";
       }
       public int UnitPrice(string product)
       {
           int unitprice=0;
           foreach(Calculate c in CalculateList)
           {
               if(c.Product==product)
               {
                   unitprice=c.Unitprice;
               }
           }
           return unitprice;
       }
       public void AddCalculateList(String product, int quantity, int Amount)
       {
           foreach (Calculate x in CalculateList)
           {
               if (x.Product == product)
               {
                   x.Quantity += quantity;
                   x.Total += Amount;
               }

           }
       }

       public override string ToString()
{    
          
           string x="";
           int sum=0;
           x += "Product Name" + "\t:\t" + "Unitprice" + "\t:\t" + "Quantity" + "\t:\t" + "Amount" + "\n";
           foreach (Calculate c in CalculateList)
           {
               x += c.Product + "\t:\t" + c.Unitprice + "\t:\t" + c.Quantity + "\t:\t" + c.Total + "\n";
               sum += c.Total;
           }
           x += sum;
           return x;

 	// return base.ToString();
}
       













    }
}
