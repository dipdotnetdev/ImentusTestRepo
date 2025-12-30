using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Generics
{
    public interface IRepository<T>
    {
        void Add(T entity);
    }
    public class GenericInterface : IRepository<string>
    {
        public void Add(string item) {
            Console.WriteLine($"{item} added.");
        }
    }
}
