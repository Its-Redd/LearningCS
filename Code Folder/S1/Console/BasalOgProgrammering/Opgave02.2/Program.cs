using System;

namespace Opgave02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hello();
            Magic();

            dontEnd();
        }

        static void hello()
        {
            //2.1
            Console.WriteLine("Hello World");

            //2.3
            Console.WriteLine("Simsalabim");
        }

        static void Magic()
        {
            Console.WriteLine("Hokus Pokus");
        }

        static void dontEnd()
        {
            Console.WriteLine();
            Console.WriteLine("Press Anything to close the program...");
            Console.ReadLine();
        }
    }
}
