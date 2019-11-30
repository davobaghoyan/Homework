using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class Sale
    {
        public string Productname { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public Sale() { }
         public  Sale (string name, DateTime date, double price)
        {
            Productname = name;
            Date = date;
            Price = price;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
