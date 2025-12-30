using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Design_Patterns.Creational
{
    public class PrototypeDP
    {
        public static void Main6()
        {
            PEmployee employee = new PEmployee();
            employee.Name = "Test";
            employee.Description = "Test";

            //Clone
            PEmployee employee1 = employee;
            employee1.Description = "Test Description";
            employee1.Name = "Test";
        }
    }

    public class PEmployee
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
