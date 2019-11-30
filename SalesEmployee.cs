using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class SalesEmployee:Regular_Employee
    {
        private List<Sale> setofsales;
        public List <Sale> SetofSales { get => setofsales; set => setofsales = value; }
        public SalesEmployee() { }
        public SalesEmployee(int id_, string first, string last, string dep, double sal, List <Sale> sales) : base(id_, first, last, dep, sal)
        {
            setofsales = sales;
        }

        public override string ToString()
        {
        return $"Employee ID {id}  Firstname {firstname}  Lastname {lastname}  Department {deparment}  Salary {salary}  CountofSales {setofsales.Count}";
        }
    }
}
