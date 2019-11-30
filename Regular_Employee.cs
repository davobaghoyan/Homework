using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class Regular_Employee:Employee
    {
       public  Regular_Employee() { }
        public Regular_Employee(int id_, string first, string last, string dep, double sal) : base(id_, first, last, dep, sal)
        { }
    }
}
