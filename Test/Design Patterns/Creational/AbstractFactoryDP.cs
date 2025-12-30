using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Design_Patterns.Creational;

namespace Test.Design_Patterns.Creational
{
    public interface IBike
    {
        void GetDetails();
    }

    public interface ICar
    {
        void GetDetails();
    }

    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Regular bike");
        }
    }

    public class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Sports Bike");
        }
    }

    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Regular Car");
        }
    }


    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Sports Car");
        }
    }

    public interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }

    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }

        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }

    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }
        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }

    public class AbstractFactoryDP
    {
        public static void Main4()
        {
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();

            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();
            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();

            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();

            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();
            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();
        }
    }
}
