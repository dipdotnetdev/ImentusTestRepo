using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Employee
    {
        public string Name {  get; set; }
        public List<string> Skills {  get; set; }

        public string Department {  get; set; }
        public double Salary {  get; set; }
        public Employee(string name, List<string> skills, string department, double salary)
        {
            Name = name;
            Skills = skills;
            Department = department;
            Salary = salary;
        }
    }
}
