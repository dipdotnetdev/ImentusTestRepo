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

    public class Call
    {
        static void Main1()
        {
            ////New Constraints call, dependency creation logic
            NewConstraints<User> newConstraints = new NewConstraints<User>();
            User user = newConstraints.Create();
        }
    }
}
