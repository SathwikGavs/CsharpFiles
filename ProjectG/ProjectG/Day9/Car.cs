using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectG.Day9
{
    public enum FuelType
    {
        
        Diesel,
        Gasoline,
        Electric,
        Hybrid
    }
    internal class Car
    {
        public string RegistrationNo { get; set; }
        public string Model { get; set; }
        public FuelType CarFuelType { get; set; }
        public Wheel[] Wheels { get; }
        public Engine CarEngine { get; }

        public Car(string registrationNo, string model, FuelType fuelType)
        {
            RegistrationNo = registrationNo;
            Model = model;
            CarFuelType = fuelType;
            Wheels = new Wheel[4];
            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
            }
            CarEngine = new Engine();
        }

        public class Wheel
        {
            // Wheel properties and methods can be added here
        }

        public class Engine
        {
            // Engine properties and methods can be added here
        }

        internal static void TestC()
        {
            throw new NotImplementedException();
        }
    }

    class Pg
    {
        public static void TestC()
        {
            Car myCar = new Car("OO7", "Lamborghini Huracan STO", FuelType.Hybrid);

            // Accessing inner classes
            Car.Wheel wheel = new Car.Wheel();
            Car.Engine engine = new Car.Engine();

            // Using properties and methods of the Car class
            Console.WriteLine($"Car Registration No: {myCar.RegistrationNo}");
            Console.WriteLine($"Car Model: {myCar.Model}");
            Console.WriteLine($"Car Fuel Type: {myCar.CarFuelType}");
            Console.WriteLine($"Car Engine Type: 5.2 L V10");
            // You can also access wheel and engine using myCar.Wheels[i] and myCar.CarEngine
        }
    }
}
    

