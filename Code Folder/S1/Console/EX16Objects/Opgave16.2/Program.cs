using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHandler;

namespace Opgave16._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create list for cars
            List<Car> cars = new List<Car>();

            // Create cars
            Car car1 = new Car("Ford", "Mustang", 1969, "Red");
            Car car2 = new Car("Skoda", "Fabia", 2010, "Black");
            Car car3 = new Car("Volkswagen", "Golf", 2015, "White");
            Car car4 = new Car("Ford", "Focus", 2018, "Blue");
            Car car5 = new Car("Ford", "Mondeo", 2017, "Green");
            
            // Add cars to list
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);

            //print all cars
            Console.WriteLine("Info om vores biler:");
            foreach (Car car in cars)
            {
                Console.WriteLine(car.GetInfo());
            }

            Console.ReadKey();
        }
    }
}
