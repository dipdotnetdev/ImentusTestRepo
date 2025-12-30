using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DeveloperAttribute : Attribute
    {
        public string Name { get; }
        public string Date {  get; }

        public DeveloperAttribute(string name, string date)
        {
            Name = name;
            Date = date;
        }
    }

    [Developer("Dipak", "2025-12-23")]
    public class ProductService
    {
        [Developer("Dip","2025-12-21")]
        public void AddProduct()
        {
            Console.WriteLine("Product Added");
        }
    }
}
