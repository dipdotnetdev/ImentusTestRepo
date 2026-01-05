

using System.Collections;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Test;
using Test.Models;

class Program
{

    static void Main()
    {
        //ArrayList arrayList = new ArrayList();
        //arrayList.Add(1);
        //arrayList.Add("dipak");
        //Console.WriteLine(arrayList[1]);

        ////GenericClass.cs call
        //GenericClass<string> genericClass = new GenericClass<string> { Value = "Generic class"};
        //genericClass.Display();

        ////Generic Method call
        //int x = 5, y = 6;
        //GenericClass<int>.Swap(ref x, ref y);
        //Console.WriteLine($"x = {x}, y = {y}");

        ////GenericInterface.cs call
        //GenericInterface genericInterface = new GenericInterface();
        //genericInterface.Add("Product");


        ////ClassConstraints call, Common in repositories and services. Can be null
        ////Product product = new Product
        ////{
        ////    Id = 1,
        ////    Name = "Test",
        ////};
        //ClassConstraints<string> classConstraints = new ClassConstraints<string>{ Data = "Apple"};
        ////classConstraints.Data.Id = 1;
        ////classConstraints.Data.Name = "Apple";
        //classConstraints.Display();


        ////Struct Constraints call, Prevents null
        //StructConstraints<int> structConstraints = new StructConstraints<int>{Value = 1};
        //structConstraints.Print();


        ////Base Constraints call, Common in domain models
        //BaseConstraints<Vehicle> baseConstraints = new BaseConstraints<Vehicle>();
        //baseConstraints.Run(new Car());
        //baseConstraints.Break(new Car());

        ////New Constraints call, dependency creation logic
        //NewConstraints<User> newConstraints = new NewConstraints<User>();
        //User user = newConstraints.Create();


        ////Interface Constraints call
        //InterfaceConstraints<ILogger> interfaceConstraints = new InterfaceConstraints<ILogger>();
        //interfaceConstraints.Execute(new Logger());

        ////TestDelegate.cs call
        //TestDelegate testDelegate = new TestDelegate(); 
        //MyDelegate myDelegate = testDelegate.Test;
        ////Multicast Delegates
        //myDelegate += testDelegate.Print;

        //MyDelegate2 myDelegate2 = testDelegate.Test2;
        //myDelegate();
        //myDelegate2("profile reached");



        ////MulticastDeligateClass.cs call
        //MulticastDelegateClass md = new MulticastDelegateClass();
        //SMS sMS = new SMS();
        //Email email = new Email();

        //md.Notify += sMS.SendSMS;
        //md.Notify += email.SendEmail;
        //md.SendNotification("Alert");

        ////Anonymous delegate call
        //MyDelegate2 md2 = delegate (string message)
        //{
        //    Console.WriteLine(message);
        //};
        //md2("new message");


        ////EventClass.cs call
        //EventClass eventClass = new EventClass();
        //eventClass.OnCompleted += () => Console.WriteLine("Completed");

        ////EventHandler.cs call
        //static void Wakeup(object sender, EventArgs eventArgs)
        //{
        //    Console.WriteLine("Wake Up");
        //}
        //static void Service_OrderProcessed(object sender, OrderEventArgs e)
        //{
        //    Console.WriteLine($"Order {e.OrderID} is {e.Status}");
        //}
        //EvenHandlerClass e = new EvenHandlerClass();
        //e.AlarmRing += Wakeup;
        //e.Ring();

        //e.OrderProcessed += Service_OrderProcessed;
        //e.ProcessOrder(101);

        ////CustomEventClass.cs call
        //var custom = new CustomEventClass();
        //custom.PriceChanged += (sender, e) =>
        //{
        //    Console.WriteLine($"{e.Symbol}: ${e.OldPrice} → ${e.NewPrice} ({e.ChangePercent:F2}%)");
        //};
        //custom.UpdatePrice("AAAP", 152);


        //string path = @"E:\files\dir\file.txt";
        ////file creation and content insertion
        //File.WriteAllText(path, "file creation test");
        ////Read file content
        //File.ReadAllText(path);

        ////Create folders
        //Directory.CreateDirectory(path);
        ////Get Files lists
        //Directory.GetFiles(path);

        ////Streams process data piece by piece
        ////Write
        //using FileStream fileStream = new FileStream(path, FileMode.Create);
        //byte[] data = Encoding.UTF8.GetBytes("hello");
        //fileStream.Write(data, 0, data.Length);

        ////Read
        //byte[] bytes = new byte[fileStream.Length];
        //fileStream.Read(bytes, 0, bytes.Length);
        //string text = Encoding.UTF8.GetString(bytes);

        ////StreamReader/StreamWrite
        ////Sit on top of FileStream and handle encoding automatically
        ////Best for logs, reports, CSV, plain text files.
        //using StreamWriter  streamWriter = new StreamWriter(path);
        //streamWriter.WriteLine("welcome");
        //streamWriter.WriteLine("to Imentus");

        //using StreamReader streamReader = new StreamReader(path);
        //string line;
        //while ((line = streamReader.ReadLine()) != null)
        //{
        //    Console.WriteLine(line);
        //}

        ////Serialization
        ////Converts an object into a format that can be stored or transmitted.
        ////Like File, JSON,XML

        ////JSON Serialization
        //Person p = new Person { Id = 1, Name = "Imentus" };
        //string json = JsonSerializer.Serialize(p);
        //File.WriteAllText(path, json);

        ////JSON Deserialization
        //string dJson = File.ReadAllText(path);
        //Person person = JsonSerializer.Deserialize<Person>(dJson);

        ////XML Serialization
        //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
        //using FileStream fs = new FileStream("person.xml", FileMode.Create);
        //xmlSerializer.Serialize(fs, p);

        ////XML Deserailization
        //using FileStream fsm = new FileStream("person.xml", FileMode.Open);
        //Person person1 = (Person)xmlSerializer.Deserialize(fsm);


        ////ThreadsClass.cs call
        //Thread thread = new Thread(ThreadClass.PrintNums);
        //thread.Start();
        //// threadStart = new ThreadStart(ThreadClass.PrintNums);

        ////Lock Thread
        //Locked locked = new Locked();
        //Thread t1 = new Thread(locked.Incerement);
        //Thread t2 = new Thread(locked.Incerement);
        //t1.Start();
        //t2.Start();

        ////Thread Pooling
        //static void Print(object msg)
        //{
        //    Console.WriteLine("ThreadPool: " + msg);
        //}
        //ThreadPool.QueueUserWorkItem(Print, "Task");

        ////Task - For backgroud OPs
        //Task task = Task.Run(() =>
        //{
        //    Console.WriteLine("Task Running in background");
        //});

        //Task task1 = Task.Run(() =>
        //{
        //    Console.WriteLine("Task 1 running");
        //}
        //);
        ////Wait until task complete
        //task.Wait(task, task1);




        ////Parallel - Allows parallel execution
        ////Works with integer index ranges
        //Parallel.For(1, 6, i =>
        //{
        //    Console.WriteLine($"Processing num: {i}");
        //});

        ////Works with any collection type
        //string[] names = { "im", "el", "oi", "yu" };
        //Parallel.ForEach(names, name =>
        //{
        //    Console.WriteLine($"{name}");
        //});

        ////Type : Used to inspect types at runtime.
        //Type type = typeof(Person);
        //Console.WriteLine(type.Name);
        //Console.WriteLine(type.Namespace);

        ////Attribute read using reflection - 
        //Type type = typeof(ProductService);

        //var classAttribute = type.GetCustomAttributes(typeof(DeveloperAttribute), false);

        //foreach (DeveloperAttribute developerAttribute in classAttribute)
        //{
        //    Console.WriteLine($"Class {developerAttribute.Name}, {developerAttribute.Date}");
        //}

        //foreach (var attr in type.GetMethods())
        //{
        //    var methodattr = attr.GetCustomAttributes(typeof(DeveloperAttribute), true);

        //    foreach (DeveloperAttribute attribute in methodattr)
        //    {
        //        Console.WriteLine($"Method {attr.Name}, {attribute.Name}");
        //    }
        //}


        ////IndexerClass.cs call - Object of class behave like Array.
        //IndexerClass indexer = new IndexerClass();
        //indexer[0] = "app";
        //indexer[1] = "web";
        //indexer[2] = "dev";
        //Console.WriteLine($"{indexer[0]}, {indexer[1]}, {indexer[2]}");

        ////Multi Dimension
        //indexer[1, 0] = "test10";
        //indexer[2, 0] = "test20";
        //Console.WriteLine($"{indexer[1, 0]}, {indexer[2, 0]}");

        ////LINQ
        //var greetings = new List<string> { "hi", "welcome", "to", "imentus" };
        //var list = greetings.Select(x => x[0].ToString().ToUpper() + x.Substring(1));


        //var employees = new List<Employee>()
        //{
        //    new Employee(
        //        name:"Lional Messi",
        //        skills: new List<string>{"dribbling", "freekick"},
        //        department: "GOAT",
        //        salary: 100
        //        ),
        //     new Employee(
        //        name:"Naymar jr.",
        //        skills: new List<string>{"dribbling", "joga banito"},
        //        department: "Prince",
        //        salary: 200

        //        ),
        //      new Employee(
        //        name:"Raphinia",
        //        skills: new List<string>{"clutch player", "big games"},
        //        department:"unlucky",
        //        salary:150
        //        ),
        //       new Employee(
        //        name:"Lamine",
        //        skills: new List<string>{"clutch player", "big games"},
        //        department:"Kid",
        //        salary:250
        //        ),
        //};

        //var selectEmp = employees.Select(emp => emp.Skills);
        //var selectManyEmp = employees.SelectMany(emp => emp.Skills);

        //foreach ( var emp in selectEmp )
        //{
        //    Console.WriteLine($"{emp[0]}");
        //}
        //foreach( var emp in selectManyEmp)
        //{
        //    Console.WriteLine($"{emp}");
        //}
        //var results1 = employees.OrderByDescending(n => n.Name);
        //foreach (Employee employee in results1)
        //    Console.WriteLine($"{employee.Name}, {employee.Department}, {employee.Salary}");

        //var results = employees.OrderByDescending(n => n.Name).ThenBy(n=> n.Salary);
        //foreach(Employee employee in results) 
        //    Console.WriteLine($"{employee.Name}, {employee.Department}, {employee.Salary}");


        //List<Person> studentList = new List<Person>()
        //    {
        //        new Person(){Id = 1, Name = "James"},
        //        new Person(){Id = 2, Name = "Sara"},
        //        new Person(){Id = 3, Name = "Steve"},
        //        new Person(){Id = 4, Name = "Pam"}
        //    };
        ////Linq Query to Fetch all students with Gender Male
        //var QuerySyntax = from std in studentList
        //                                   where std.Name == "Sara"
        //                                   select std;


        ////LINQ Sets
        //int[] sequence1 = { 1, 2, 3, 4, 5 };
        //int[] sequence2 = { 4, 5, 6, 7, 8 };
        //var distinct = sequence1.Distinct();
        //Console.WriteLine("Distinct: " + string.Join(", ", distinct));
        //var union = sequence1.Union(sequence2);
        //Console.WriteLine("Union: " + string.Join(", ", union));
        //var intersect = sequence1.Intersect(sequence2);
        //Console.WriteLine("Intersect: " + string.Join(", ", intersect));
        //var except = sequence1.Except(sequence2);
        //Console.WriteLine("Except: " + string.Join(", ", except));
        //var concatenated = sequence1.Concat(sequence2);
        //Console.WriteLine("Concat: " + string.Join(", ", concatenated));
        //bool areEqual = sequence1.SequenceEqual(sequence2);
        //Console.WriteLine($"SequenceEqual: {areEqual}");
    }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}