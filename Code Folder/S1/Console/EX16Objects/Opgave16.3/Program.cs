using CarHandler;
using System;
using System.Collections.Generic;

namespace Opgave16._3
{
    internal class Program
    {
        static List<Car> cars = new List<Car>();
        static void Main()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Create a new car");
            Console.WriteLine("2. Display all cars");
            Console.WriteLine("3. Søg efter bilnavn");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your selection: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    CreateCar();
                    return true;
                case "2":
                    DisplayAllCars();
                    return true;
                case "3":
                    GetCarByName();
                    return true;
                case "4":
                    return false;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    return true;
            }
        }

        static void CreateCar()
        {

            Console.Write("Enter the make of the car: ");
            string make = Console.ReadLine();
            Console.Write("Enter the model of the car: ");
            string model = Console.ReadLine();
            Console.Write("Enter the year of the car: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter the color of the car: ");
            string color = Console.ReadLine();

            

            Car newCar = new Car(make, model, year, color);
            cars.Add(newCar);

            int tries = 0;
            bool startcar = false;
            while (!startcar)
            {
                if (newCar.StartCar() == true)
                {
                    tries++;
                    startcar = true;
                }
                else if (tries > 20)
                {
                    Console.WriteLine("The car could not start after 20 tries.");
                    startcar = false;
                    break;
                }
                else
                {
                    tries++;
                    startcar = false; //Not needed, but for clarity
                }
            }

            if (startcar == true)
            {
                Console.WriteLine($"The car started after {tries} tries.");
            }

            Console.WriteLine("Car added successfully!");
            Console.ReadKey();
        }

        static void DisplayAllCars()
        {
            Console.WriteLine("List of all cars:");
            foreach (var car in cars)
            {
                Console.WriteLine(car.GetInfo());
            }
            Console.ReadKey();
        }

        static void GetCarByName()
        {
            Console.Write("Enter the name of the car: ");
            string name = Console.ReadLine();
            foreach (var car in cars)
            {
                if (car.Make == name)
                {
                    Console.WriteLine(car.GetInfo());
                }
            }
            Console.ReadKey();
        }

    }
}
