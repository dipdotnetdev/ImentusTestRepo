using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Constraints
{
    public class User
    {
        public User() { }
    }
    public class NewConstraints<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
