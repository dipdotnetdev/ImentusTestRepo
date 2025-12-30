using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Constraints
{

    public class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle started");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }
    }

    public class Car : Vehicle { }

    public class BaseConstraints<T> where T : Vehicle
    {
        public void Run(T vehicle)
        {
            vehicle.Start();
        }

        public void Break(T vehicle)
        {
            vehicle.Stop();
        }
    }
}
