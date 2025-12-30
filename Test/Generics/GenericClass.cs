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

    public class GenericCall
    {
        static void Main()
        {
            GenericClass<string> genericClass = new GenericClass<string> { Value = "Generic class" };
            genericClass.Display();

            int x = 5, y = 6;
            GenericClass<int>.Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
