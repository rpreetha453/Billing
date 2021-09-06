using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
   public class Calculate
    {
        string _product;

        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }
        int _unitprice;

        public int Unitprice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }
       
        int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        int _total;

        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public Calculate(string product, int unitprice, int quantity, int total)
        {
            this.Product = product;
            this.Unitprice = unitprice;

            this.Quantity = quantity;
            this.Total = total;
        }







    }
}
