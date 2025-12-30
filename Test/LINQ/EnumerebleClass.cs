using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LINQ
{
    public class EnumerebleClass
    {
        public void EnumerableMethod()
        {
            var numbers = new List<int> { 1, 2, 3,4,5,6 };

            var oddNumber = numbers.Where(n => n % 2 == 0).Select(number => number);
            var squares = numbers.Select(n => n*n).OrderBy(n => n);
            foreach (var number in oddNumber)
            {
                Console.WriteLine(number);
            }
        }
    }
}
