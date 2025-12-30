using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Generics
{
    public class GenericClass<T>
    {
        public T Value { get; set; }

        public void Display()
        {
            Console.WriteLine(Value);
        }

        public static void Swap<T> (ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
