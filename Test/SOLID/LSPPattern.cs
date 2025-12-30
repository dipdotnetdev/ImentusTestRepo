using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SOLID
{
    //Liskov Substitution - Derived/Child class must be substitutable for base class
    //Child class can replace methods of Parent class
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying");
        }
    }

    public class Panguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Panguin can't fly");
        }
    }

    //Solution
    public interface IFLyingBird
    {
        void Fly();
    }

    class Sparrow : IFLyingBird
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow flying");
        }
    }

    class Penguin
    {
        public void Swim() => Console.WriteLine("Swimming");
    }
}
