using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ThreadClass
    {
        public static void PrintNums()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread : {Thread.CurrentThread.ManagedThreadId}, Value: {i}");
                Thread.Sleep(1000);
            }
        }
    }

    public class Locked
    {
        private int count = 0;
        private readonly object lockObj = new object();

        public void Incerement()
        {
            lock(lockObj)
            {
                count++;
                Console.WriteLine($"{count}");
            }
        }
    }
}
