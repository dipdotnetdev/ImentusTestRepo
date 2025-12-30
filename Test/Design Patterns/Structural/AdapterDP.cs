using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Structural
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary {  get; set; }

        public Employee(int id, string name, string designation, decimal salary)
        {
            Id = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }
    }

    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Salry {employee.Salary} Rs. Credited to {employee.Name} Account");
            }
        }
    }

    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeeSalary);
    }

    public class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem ThirdPartyBillingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary(string[,] employeeSalary)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < employeeSalary.GetLength(0); i++)
            {
                for(int j = 0; j  < employeeSalary.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        Id = employeeSalary[i,j];
                    }
                    else if(j == 1)
                    {
                        Name = employeeSalary[i,j];
                    }
                    else if(j == 2)
                    {
                        Designation = employeeSalary[i,j];
                    }
                    else if (j == 3)
                    {
                        Salary = employeeSalary[i,j];
                    }
                }
                employees.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
                ThirdPartyBillingSystem.ProcessSalary(employees);
            }
        }
    }

    public class AdapterDP
    {
        public void SalaryProcessMethod()
        {
            string[,] employee = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };

            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employee);
        }
    }
}
