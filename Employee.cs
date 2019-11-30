using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class Employee : Person
    {
        protected string deparment;
        protected double salary;

        public string Department
        {
            get => deparment;
            set
            {
                if (value == "Production" || value == "Accounting" || value == "Sales" || value == "Marketing")
                    deparment = value;
                else
                    throw new Exception("Wrong department");
            }
        }

        public double Salary
        { get => salary; set => salary = value; }

        public Employee() { }
        public Employee (int id_, string first, string last, string dep, double sal  ): base (id_, first , last)
        {
            deparment = dep;
            salary = sal;
        }

        public override string ToString()
        {
            return $"Employee ID {id}  Firstname {firstname}  Lastname {lastname}  Department {deparment}  Salary {salary} ";
        }
    }
}
