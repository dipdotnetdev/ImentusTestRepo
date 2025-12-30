using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public delegate void Notify();
    public class EventClass
    {
        public event Notify OnCompleted;

        public void Start()
        {
            Console.WriteLine("Started");
            OnCompleted.Invoke();
        }
    }
}
