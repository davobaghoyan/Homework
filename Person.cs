using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class Person
    {
        protected int id;
        protected string firstname;
        protected string lastname;

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }

        public Person () { }

        public Person (int ID, string First_name, string Last_name)
        {
            id = ID;
            firstname = First_name;
            lastname = Last_name;
        }
        public override string ToString()
        {
            return $"Person ID {Id}   Firstname {firstname}   Lastname {lastname}";
        }
    }
}
