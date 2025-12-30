using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Structural
{
    public class Employees
    {
        public string UserName { get; set; }
        public string Password {  get; set; }
        public string Role {  get; set; }

        public Employees(string userName, string password, string role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }
    }

    public interface ISharedFolder
    {
        void PerformRWOperations();
    }

    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
        {
            Console.WriteLine("Perform Read/Write Ops");
        }
    }

    public class SharedProxyFolder : ISharedFolder
    {
        private ISharedFolder _sharedFolder;
        private Employees _employee;

        public SharedProxyFolder(Employees employee)
        {
            _employee = employee;
        }

        public void PerformRWOperations()
        {
            _sharedFolder = new SharedFolder();
            _sharedFolder.PerformRWOperations();
        }
    }

    public class ProxyDP
    {
        static void Main12()
        {
            Employees employees = new Employees("Dipak", "k4p4d", "Admin");
            SharedProxyFolder sharedProxyFolder = new SharedProxyFolder(employees);
            sharedProxyFolder.PerformRWOperations();
        }
    }
}
