using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave04
{
    internal class Program
    {
        static void Hax()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }



        static void Main(string[] args)
        {
            Hax();

            //4
            Console.Write("Indtast en værdi til din variabel: ");
            int userInput = int.Parse(Console.ReadLine());
            userInput = userInput + 12;
            Console.WriteLine($"Dit tal er nu blevet øget med 12 og har nu værdien {userInput}");





            dontEnd();
        }

        static void dontEnd()
        {
            Console.WriteLine();
            Console.WriteLine("Press Anything to close the program...");
            Console.ReadLine();
        }
    }
}
