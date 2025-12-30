using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Constraints
{
    public interface ILogger
    {
        void Log();
    }

    public class Logger : ILogger
    {
        public void Log() {
            Console.WriteLine("logged");
        }
    }
    public class InterfaceConstraints<T> where T : ILogger
    {
        public void Execute(T logger)
        {
            logger.Log();
        }
    }

    public class InterfaceCall
    {
        public void Main()
        {
            ////Interface Constraints call
            InterfaceConstraints<ILogger> interfaceConstraints = new InterfaceConstraints<ILogger>();
            interfaceConstraints.Execute(new Logger());
        }
    }
}
