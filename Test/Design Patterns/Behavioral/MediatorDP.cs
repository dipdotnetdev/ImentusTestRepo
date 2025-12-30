

namespace Test.Design_Patterns.Behavioral
{
    public interface IGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }

    public class ConcreteGroupMediator : IGroupMediator
    {
        private List<User> users = new List<User>();

        public void RegisterUser(User user)
        {
            users.Add(user);
            user.Mediator = this;
        }

        public void SendMessage(string message, User user)
        {
            foreach(User u in users)
            {
                if(u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }

    public abstract class User
    {
        protected string Name;

        public IGroupMediator Mediator { get; set; }

        public User(string name)
        {
            this.Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }

    public class ConcreteUser : User
    {
        public ConcreteUser(string name) : base(name)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{this.Name} sending message: {message}");
            Mediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{this.Name} recieved message: {message}");
        }
    }

    public class MediatorDP
    {
        static void Main2()
        {
            IGroupMediator groupMediator = new ConcreteGroupMediator();

            User dip = new ConcreteUser("Dipak");
            groupMediator.RegisterUser(dip);
            dip.Send("welcome to imentus");
        }
    }
}
