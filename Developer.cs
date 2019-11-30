using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class Developer: Regular_Employee
    {
        public List<Project> Projects { get; set; }
        public Developer () { }
        public Developer(int id_, string first, string last, string dep, double sal, List <Project> projects) : base(id_, first, last, dep, sal)
        {
            Projects = projects;
        }
        public override string ToString()
        {
            return $"Employee ID {id}  Firstname {firstname}  Lastname {lastname}  Department {deparment}  Salary {salary}  CountofProjects {Projects.Count}";
        }
    }
}
