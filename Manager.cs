using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class Manager: Employee
    {
        public List <Employee> Employees;
        public Manager () { }
        public Manager(int id_, string first, string last, string dep, double sal, List <Employee> employees) : base(id_, first, last, dep, sal)
        {
            Employees = employees;
        }
    }
}
