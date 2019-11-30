using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee I = new Employee(12, "Davit", "Baghoyan", "Production", 800000000);
            Console.WriteLine(I);
            Console.Read();
        }
    }
}
