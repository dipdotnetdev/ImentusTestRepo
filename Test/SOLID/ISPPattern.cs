using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SOLID
{
    //Interface Sagregation - 
    //Clients should not be forced to depend on methods they do not use
    //Classes should not implement methods they don't need
    public interface IWorker
    {
        void Run();
        void Eat();
    }
    public class Robot : IWorker
    {
        public void Run()
        {
            Console.WriteLine("Robot running");
        }

        public void Eat()
        {
            Console.WriteLine("Robot does not eat. As per now");
        }
    }

    //Solution - Create saperate interfaces

    interface IRunnable
    {
        void Run();
    }
    interface IEat
    {
        void Eat();
    }

    public class Robo : IRunnable 
    {
        public void Run()
        {
            Console.WriteLine("Run Robo");
        }
    }

    public class Human : IRunnable, IEat
    {
        public void Run()
        {
            Console.WriteLine("Human running");
        }

        public void Eat()
        {
            Console.WriteLine("Hunan eating");
        }
    }
}
