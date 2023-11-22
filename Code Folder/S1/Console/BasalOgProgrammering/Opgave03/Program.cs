using System;

namespace Opgave03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.2
            Console.Write("Dig");
            Console.Write(" og mig");
            Console.Write(" og vi to");
            Console.WriteLine(" sejled i en træsko");
            Console.Write("Da vi kom til");
            Console.Write(" Langeland");
            Console.Write(" var vor træsko fuld af vand");


            // Spacing
            Console.WriteLine("\n\n\n");



            //3.4
            Console.Write("Indtast navneord: ");
            string inputOne = Console.ReadLine().ToLower();

            Console.Write("Indtast udsagnsord i nutid: ");

            string inputTwo = Console.ReadLine().ToLower();

            Console.Write("Indtast tillægsord i flertal (f.eks. smukke): ");
            string inputThree = Console.ReadLine().ToLower();

            Console.Write("Indtast navneord: ");
            string inputFour = Console.ReadLine().ToLower();

            if (inputOne == "succes" & inputTwo == "hører" & inputThree == "fede" & inputFour == "musik")
            {
                Console.WriteLine("\nmasser af succes");
                Console.WriteLine("Og det hører til");
                Console.WriteLine("Masser af fede spotlights");
                Console.WriteLine("Privatliv og musik");
                Console.WriteLine("- Kim Larsen");
            }
            else
            {
                Console.WriteLine("\nRimelig sikker på Kim larsen ikke sang: ");
                Console.WriteLine($"Masser af {inputOne}");
                Console.WriteLine($"Og det {inputTwo} til");
                Console.WriteLine($"Masser af {inputThree} spotlights");
                Console.WriteLine($"Privatliv og {inputFour}");

            }




            // Please for the love of god DO NOT end automatically!
            DontEnd();
        }

        static void DontEnd()
        {
            Console.WriteLine();
            Console.WriteLine("Press Anything to close the program...");
            Console.ReadLine();
        }
    }
}
