using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHandler;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Mustang", 1969, "Red");

            Console.WriteLine(car1.GetInfo());
            Console.WriteLine(car1.ToString());
            // .ToString() doesn't give me the color of the car, only the make, model and production year.


            // Spacing
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Skifter farve til 'Blue':");
            car1.Color = "Blue";
            // car1.Model = "Focus"; // This is not possible, because the Model property is read-only.
            Console.WriteLine(car1.GetInfo());

            // StartCar() returns a bool, so we can use it in a if statement or such.
            Console.WriteLine($"Did car start: {car1.StartCar()}");

            Console.ReadKey();
        }
    }
}
