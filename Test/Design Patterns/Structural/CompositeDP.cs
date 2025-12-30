using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Structural
{
    public interface IComponent
    {
        void DisplayPrice();
    }

    public class Leaf : IComponent
    {
        public int Price {  get; set; }
        public string Name { get; set; }

        public Leaf(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}");
        }
    }

    public class Composite : IComponent
    {
        public string Name { get; set; }

        List<IComponent> components = new List<IComponent>();

        public Composite(string name)
        {
            this.Name=name;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void DisplayPrice()
        {
            foreach(var item in components)
            {
                item.DisplayPrice();
            }
        }
    }

    public class CompositeDP
    {
        static void Main8()
        {
            IComponent hardDisk = new Leaf("hardDisk", 2300);
            IComponent ram = new Leaf("RAM", 5000);

            Composite motherBoard = new Composite("MotherBoard");
            Composite cabinet = new Composite("Cabinet");

            motherBoard.AddComponent(hardDisk);
            motherBoard.AddComponent(ram);

            motherBoard.DisplayPrice();
            cabinet.DisplayPrice();
        }
    }
}
