using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Constraints
{
    public class StructConstraints<T> where T : struct
    {
        public T Value;

        public void Print()
        {
            Console.WriteLine($"{Value}");
        }
    }

    public class StructCall
    {
        public void Main()
        {
            ////Struct Constraints call, Prevents null
            StructConstraints<int> structConstraints = new StructConstraints<int> { Value = 1 };
            structConstraints.Print();
        }
    }
}
