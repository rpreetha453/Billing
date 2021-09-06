using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
  class Program
    {
     static CalculateBill b = new CalculateBill();
         
        static void Main(string[] args)
        {
        
            string x="";
            do{
                List<Calculate> a=new List<Calculate>();
                Console.Clear();
                Console.WriteLine("Green Tea-0\t"+"Cappucino-1\t"+"Hot Chocolate-2 \t"+"Cafe Late-3 \t"+"Chai-4");
                do{
                GetValue(a);
                Console.WriteLine("Do you want to continue?\n Press c\n Press q to close Today Billing");
                x = Console.ReadLine();
                }while(x=="c" ||x=="C");
                display(a);
                Console.ReadLine();
            }while(x!="q");
            Console.WriteLine("___________________________TODAY SALES________________________");
            Console.WriteLine(b);
        }
        public static void display(List<Calculate> a)
        {

            int sum = 0;
            Console.WriteLine("Product Name \t  Quantity   \t   Unitprice  \t  Amount");
            foreach (Calculate c in a)
            {
                Console.WriteLine( c.Product + "\t" + c.Quantity + "\t" + c.Unitprice + "\t" + c.Total );
                sum += c.Total;
            }
            Console.WriteLine("TotalAmount:" +sum);
           

            }
        public static void GetValue(List<Calculate> a)
        {
                Console.WriteLine("Enter the ProductnNo:");
                int ProductNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());
                string ProductName =b.Productname(ProductNo);
                int Unitprice =b.UnitPrice(ProductName);
                
                int Amount = Unitprice * quantity ;
               
                Calculate c = new Calculate(ProductName, quantity, Unitprice,Amount);
            a.Add(c);
                b.AddCalculateList(ProductName,quantity,Amount);
               }
     








        }
    }

