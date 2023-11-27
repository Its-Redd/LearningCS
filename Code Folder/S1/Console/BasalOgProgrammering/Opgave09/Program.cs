using System;

namespace Opgave09
{
    internal class Program
    {
        public static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Vælg et prgram:");
                Console.WriteLine("1. Ros");
                Console.WriteLine("2. BMI Lommeregner");
                Console.WriteLine("3. Rest ved divison");
                Console.WriteLine("4. Exit");

                Console.Write("Indtast dit valg: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Du valgte ros");
                        Console.Write("\nIndtast dit navn: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Hvad vil du gerne have ros for? (et ord): ");
                        string praise = Console.ReadLine().ToLower();
                        Hello(name, praise);
                        break;
                    case "2":
                        Console.WriteLine("Du valgte BMI udregner");
                        Console.WriteLine("\nVelkommen til BMI-lommeregneren!");

                        Console.Write("Indtast din vægt i kg: ");
                        double vægt = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Indtast din højde i centimeter: ");
                        double højde = Convert.ToDouble(Console.ReadLine());

                        double bmi = CalculateBMI(vægt, højde);

                        Console.WriteLine($"Din BMI er: {bmi}");

                        PrintBMI(bmi);

                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Du valgte Rest ved Divison");
                        Console.WriteLine();
                        TestRest();
                        Console.ReadKey();


                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.Write("Indtast dit navn: ");


            }

            Console.ReadKey();
        }

        private static void Hello(string printName, string printPraise)
        {
            Console.WriteLine($"Hej {printName}, fantastisk {printPraise}!");
        }

        static double CalculateBMI(double vægt, double højde)
        {
            double bmi = vægt / ((højde / 100) * (højde / 100));
            return bmi;
        }


        static void PrintBMI(double bmi)
        {
            if (bmi < 18.5)
            {
                Console.WriteLine("du er undervægtig.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("du er normalvægtig.");
            }
            else
            {
                Console.WriteLine("du er overvægtig.");
            }
        }
        private static int Rest(int dividend, int divisor)
        {

            return dividend % divisor;
        }

        private static void TestRest()
        {
            Console.WriteLine("Indtast det første heltal:");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast det andet heltal:");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int result = Rest(input1, input2);

            Console.WriteLine("Resten ved division er: " + result);
        }
    }

}
