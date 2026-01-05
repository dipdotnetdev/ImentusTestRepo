using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Constraints
{
    public class ClassConstraints<T> where T : class
    {
        public T Data { get; set; }

        //public ClassConstraints(T data)
        //{
        //    Data = data;
        //}

        public void Display()
        {
            Console.WriteLine(Data == null ? "Null Data" : Data);
        }
    }

    public class ClassCall
    {
        static void Main1()
        {
            ClassConstraints<string> classConstraints = new ClassConstraints<string> { Data = "Apple" };
            //classConstraints.Data.Id = 1;
            //classConstraints.Data.Name = "Apple";
            classConstraints.Display();
        }
    }
}
