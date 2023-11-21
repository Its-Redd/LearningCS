using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Opgave06
{
    internal class Program
    {
        public static class Globals
        {
            public static int menuChoice = 0;
        }
        static void Main(string[] args)
        {
            bool done = false;

            

            //6.3
            //Denne opgave består af den while loop der omringer koden
            while (Globals.menuChoice != 1)
            {

                Console.Clear();

                MethodChoice();

                if (Globals.menuChoice == 1)
                {
                    Globals.menuChoice = 1;
                }
                else if (Globals.menuChoice == 2)
                {
                    DontLie();
                    Console.WriteLine("\n\nPress anything to return to menu");
                    Console.ReadKey();
                }
                else if (Globals.menuChoice == 3)
                {
                    Repeater();
                    Console.WriteLine("\n\nPress anything to return to menu");
                    Console.ReadKey();
                }
                else if (Globals.menuChoice == 4)
                {
                    birthday();
                    Console.WriteLine("\n\nPress anything to return to menu");
                    Console.ReadKey();
                }
                else if (Globals.menuChoice == 5)
                {
                    //Call method here
                    Console.WriteLine("\n\nPress anything to return to menu");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n\n<<<<<<<<<<<<ERROR>>>>>>>>>>>>>>>");
                    Console.WriteLine("Press anything to return to menu");
                    Console.ReadKey();
                }

                



            }


            dontEnd();
        }

        static void DontLie()
        {
            //6.2
            int counter = 1;

            while (counter <= 6)
            {
                Console.WriteLine("Jeg må ikke lyve");
                counter++;
            }
            Console.ReadKey();
        }

        static void MethodChoice()
        {
            //6.5
            double dblParse;

            Console.WriteLine(">>> VÆLG METHOD <<<");
            Console.WriteLine("|VÆLG NUMMER|\n" +
                "1: Exit Program\n" +
                "2: DontLie()\n" +
                "3: Repeater()\n" +
                "4: Birthday()");
            Console.Write("Indtast et tal: ");
            double.TryParse(Console.ReadLine(), out dblParse);
            Globals.menuChoice = Convert.ToInt32(dblParse);
            Console.Clear();
        }

        static void Repeater()
        {
            //6.7
            double dblRepeats;

            Console.WriteLine("\n||| SÆTNING GENTAGER |||");
            Console.Write("Indtast sætning: ");
            string sentence = Console.ReadLine();

            Console.Write("Indast mængde gentagelser: ");
            double.TryParse(Console.ReadLine(), out dblRepeats);
            int repeats = Convert.ToInt32(dblRepeats);

            for (int counter = 0; counter < repeats;)
            {
                Console.WriteLine(sentence);
                Thread.Sleep(50);
                counter++;
            }
        }    
        
        static void birthday()
        {
            //6.8
            bool genderChosen = false;
            bool ageChosen = false;
            string gender = "N/A";
            int age = 0;
            

            Console.WriteLine("||| Fødselsdagsoptæller |||");
            while (genderChosen == false)
            {
                Console.Write("Indtast køn (M/K): ");
                gender = Console.ReadLine().ToLower();

                if (gender == "m")
                {
                    genderChosen = true;
                }
                else if (gender == "k")
                {
                    genderChosen = true;

                }
                else
                {
                    Console.WriteLine("\n\n<<<<<<<<<<<<ERROR>>>>>>>>>>>>>>>");
                    Console.WriteLine("Dit input var ugyldigt, prøv igen.");
                    Console.ReadKey();
                }
            }
            while (ageChosen == false)
            {
                Console.Write("Indtast alder: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    ageChosen = true;
                }
                else
                {
                    Console.WriteLine("\n\n<<<<<<<<<<<<ERROR>>>>>>>>>>>>>>>");
                    Console.WriteLine("Dit input var ugyldigt, prøv igen.");
                }
            }

            if (gender == "m")
            {
                if (age == 1)
                {
                    Console.WriteLine("Han blev 1 år, HURRRAAA....");
                }
                else
                {
                    int counter = 1;
                    if (counter == 1)
                    {
                        Console.WriteLine("Han blev 1 år, hurra,");
                        counter++;
                    }
                    else if (counter == age)
                    {
                        Console.WriteLine($"og han blev {counter} år, HURRRAAAAAAAAAAA...");
                    }
                    else
                    {
                        Console.WriteLine($"og han blev {counter} år, hurra,");
                        counter++;
                    }
                }

            }
            else
            {
                Console.WriteLine(">><<<UNKNOWN ERROR>>><<");
            }
        }

        static void dontEnd()
        {
            Console.WriteLine();
            Console.WriteLine("Press anything to close the program...");
            Console.ReadKey();
        }
    }
}
