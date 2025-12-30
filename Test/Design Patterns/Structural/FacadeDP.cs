using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Structural
{
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching Product Details...");
        }
    }

    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment done successfully.");
        }
    }

    public class Invoice
    {
        public void SendInvoice()
        {
            Console.WriteLine("Invoice sent.");
        }
    }


    public class Order
    {
        public void PlaceOrder()
        {
            Product product = new Product();
            product.GetProductDetails();

            Payment payment = new Payment();
            payment.MakePayment();

            Invoice invoice = new Invoice();
            invoice.SendInvoice();
        }
    }
    public class FacadeDP
    {
        static void Main11()
        {
            Order order = new Order();
            order.PlaceOrder();
        }
    }
}
