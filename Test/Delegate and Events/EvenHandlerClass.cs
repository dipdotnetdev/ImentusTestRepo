using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class OrderEventArgs
    {
        public int OrderID { get; set; }
        public string Status { get; set; }
    }
    public class EvenHandlerClass
    {
        public event EventHandler AlarmRing;
        public event EventHandler<OrderEventArgs> OrderProcessed;

        public void Ring()
        {
            Console.WriteLine("Ringing");
            AlarmRing.Invoke(this, EventArgs.Empty);
        }

        public void ProcessOrder(int orderId)
        {
            Console.WriteLine("Processing order .....");
            OrderProcessed.Invoke(this, new OrderEventArgs
            {
                OrderID = orderId,
                Status = "Completed"

            });
        }
    }
}

