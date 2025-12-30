using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string words);
    public delegate int Calculation(int a, int b);
    public class TestDelegate
    {
        public void Test()
        {
            Console.WriteLine("Delfate Call");
        }

        public void Print()
        {
            Console.WriteLine("multicast");
        }
        public void Test2(string str)
        {
            Console.WriteLine($"{str}");
        }

        public static int Add(int x, int y) => x + y;
        public static int Mul(int x, int y) => x * y;

        public static void Calculate(int a, int b, Calculation calculation)
        {
            Console.WriteLine($"Result: {calculation(a, b)}");
        }

    }


}
