using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class Customer : Person
    {
        public double PurchaseAmount { get; set; }
        Customer () { }
        Customer (int id_, string first, string last, double amount) : base (id_ , first , last)
        {
            PurchaseAmount = amount;
        }
        public override string ToString()
        {
            return $"Customer ID {Id}  Firstname {firstname}  Lastname {lastname}";
        }

    }
}
