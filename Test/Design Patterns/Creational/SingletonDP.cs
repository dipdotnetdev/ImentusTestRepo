using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Creational
{
    public sealed class SingletonDP
    {
        private static int Counter = 0;

        private static SingletonDP Instance = null;

        public static SingletonDP GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonDP();
            }


            return Instance;
        }

        private SingletonDP()
        {
            Counter++;
            Console.WriteLine($"Counter Value: {Counter}");
        }

        public void Print( string message)
        {
            Console.WriteLine($"{message}");
        }
    }

    //Use
    public class Program
    {
        public void Main()
        {
            SingletonDP singletonDP = SingletonDP.GetInstance();
            singletonDP.Print("Singletom Design Pattern");
        }
    }
}
