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
}
