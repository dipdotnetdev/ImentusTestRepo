using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Structural
{

    public interface ICar
    {
        ICar ManufactureCar();
    }

    public class BMWCar : ICar
    {
        private string Name = "BMW";
        public string CarBody {  get; set; }
        public string CarDoor { get; set; }
        public string CarWheels {  get; set; }
        public string CarGlass { get; set; }
        public string Engine {  get; set; }

        public override string ToString()
        {
            return $"CarName: {Name}, CarBody: {CarBody}, CarDoor: {CarDoor}, CarWheels: {CarWheels}, CarGlass: {CarGlass} and CarEngine : {Engine}";
        }
        public ICar ManufactureCar()
        {
            CarBody = "fibre";
            CarDoor = "4";
            CarWheels = "4 MRF";
            CarGlass = "6 glasses";
            return this ;
        }
    }

    public abstract class CarDecorator : ICar
    {
        protected ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual ICar ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }

    public class PetrolDecoratorCar : CarDecorator
    {
        public PetrolDecoratorCar(ICar car) : base(car) { }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();

            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if(car is BMWCar bmwCar)
            {
                bmwCar.Engine = "Petrol Engine";
            }
        }
    }

    public class DieselDecoratorCar : CarDecorator
    {
        public DieselDecoratorCar(ICar car) : base(car) { }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if(car is BMWCar bmwCar)
            {
                bmwCar.Engine = "Diesel Engine";
            }
        }
    }
    public class DecoratorDP
    {
        static void Main10()
        {
            ICar bmwCar = new BMWCar();
            bmwCar.ManufactureCar();

            PetrolDecoratorCar petrolDecorator = new PetrolDecoratorCar(bmwCar);
            petrolDecorator.ManufactureCar();

            ICar car = new BMWCar();
            DieselDecoratorCar dieselDecorator = new DieselDecoratorCar(car);
            dieselDecorator.ManufactureCar();
        }
    }
}
