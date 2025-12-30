using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SOLID
{
    //Dependency Inversion
    //Depend on Inversion, not on concrete classes
    public class FileLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    public class NewOrderService
    {
        private FileLogger fl = new FileLogger();
        
    }

    //Soltion -

    public interface ILogger
    {
        void Log(string message);
    }

    public class LoggerFile : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    public class ServiceOrder
    {
        private ILogger _logger;
        public ServiceOrder( ILogger logger )
        {
            _logger = logger;
        }
    }

}
