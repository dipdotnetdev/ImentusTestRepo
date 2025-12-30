using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SOLID
{
    //problem - One class have multiple responsibilities
    public class SRPPattern
    {
        public void CreateOrder()
        {
            Console.WriteLine("Order created");
        }

        public void Save()
        {
            Console.WriteLine("Order saved");
        }

        public void SendEamil()
        {
            Console.WriteLine("Email sent");
        }
    }


    //Solution - One class have only responisibility

    public class OrderService
    {
        public void CreateOrder()
        {
            Console.WriteLine("Order created");
        }
    }

    public class OrderRepo
    {
        public void Save()
        {
            Console.WriteLine("Order Saved to DB");
        }
    }

    public class EmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Email sent");
        }
    }
}
