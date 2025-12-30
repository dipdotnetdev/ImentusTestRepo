using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public delegate void NotificationHandler(string message);
    public class MulticastDelegateClass
    {
        public NotificationHandler Notify;

        public void SendNotification(string msg)
        {
            Notify.Invoke(msg);
        }
    }

    public class SMS
    {
        public void SendSMS(string msg) => Console.WriteLine($"SMS: {msg}");
    }

    public class Email
    {
        public void SendEmail(string msg) => Console.WriteLine($"Email: {msg}");
    }
}
