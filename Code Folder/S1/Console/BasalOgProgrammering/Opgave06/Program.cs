using System;
using System.Threading;

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
                    Return();
                }
                else if (Globals.menuChoice == 3)
                {
                    Repeater();
                    Return();
                }
                else if (Globals.menuChoice == 4)
                {
                    Birthday();
                    Return();
                }
                else if (Globals.menuChoice == 5)
                {
                    Division();
                    Return();
                }
                else
                {
                    Console.WriteLine("\n\n<<<<<<<<<<<<ERROR>>>>>>>>>>>>>>>");
                    Return();
                }
            }
            DontEnd();
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
                "4: Birthday()\n" +
                "5. Division()");
            Console.Write("Indtast et tal: ");
            double.TryParse(Console.ReadLine(), out dblParse);
            Globals.menuChoice = Convert.ToInt32(dblParse);
            Console.Clear();
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


        static void Birthday()
        {
            Console.Write("Indtast dit køn (K / M): ");
            string gender = Console.ReadLine();
            Console.Write("\nAlder?: ");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                RepeatBirthdate(age, gender);
            }
            else
            {
                Console.WriteLine("Du inputtede ikke et tal som alder.");
            }
        }
        static void RepeatBirthdate(int age, string gender)
        {
            if (gender == "m" || gender == "M")
            {
                gender = "Han";
            }
            else if (gender == "k" || gender == "K")
            {
                gender = "Hun";
            }
            else
            {
                gender = "Hen";
            }

            int i = 1;
            Console.WriteLine($"{gender} blev {i}, hurra!");
            gender = gender.ToLower();
            for (i = 2; i < age + 1; i++)
            {
                Console.WriteLine($"og {gender} blev {i}, hurra!");
            }
        }

        static void Division()
        {
            //6.9
            int input1 = 0;
            int input2 = 0;
            bool tal1 = false;
            bool tal2 = false;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************");
            Console.WriteLine("* Division ved hjælp af plus *");
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.White;

            while (tal1 == false)
            {
                Console.Write("\nIndtast tallet der skal divideres: ");
                if (int.TryParse(Console.ReadLine(), out input1))
                {
                    tal1 = true;
                }
                else
                {
                    Console.WriteLine("Dit input skal være et helt tal");
                }
            }
            while (tal2 == false)
            {
                Console.Write("Indtast tallet som der skal divideres med: ");
                if (int.TryParse(Console.ReadLine(), out input2))
                {
                    tal2 = true;
                }
                else
                {
                    Console.WriteLine("Dit input skal være et helt tal");
                }
            }

            int times = 0;
            int calculator = input2;

            while (calculator <= input1)
            {
                times++;
                calculator = calculator + input2;
            }

            int res = input1 - (calculator - input2);

            Console.WriteLine($"\n{input2} går op i {input1} {times} gange med {res} i rest");




        }

        static void Return()
        {
            Console.WriteLine("\n\nPress anything to return to menu");
            Console.ReadKey();
        }

        static void DontEnd()
        {
            Console.WriteLine();
            Console.WriteLine("Press anything to close the program...");
            Console.ReadKey();
        }
    }
}


