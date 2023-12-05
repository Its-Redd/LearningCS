using System;
using System.Collections.Generic;
using System.IO;

namespace Opgave01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\61151\\Desktop\\text.txt")) // StreamWriter Prints to a file called text.txt
            {
                sw.Write("Det her bliver skrevet på en linje");
                sw.Write(" og det her forsætter på samme linje");
                sw.WriteLine(" og det her står på samme linje, men afsluttes med et linjeskift");
                sw.WriteLine("og det her står på en ny linje");
                // Forskellen er at Write skriver på samme linje, mens WriteLine skriver på en ny linje


            }


            Random random = new Random(); // Creates a new random object
            using (StreamWriter sw2 = new StreamWriter("C:\\Code Folder\\S1\\Console\\EX20StreamWriter\\Opgave01-02\\test.txt")) // StreamWriter Prints to a file called text.txt located in the same folder as the .exe file
            {
                for (int i = 0; i <= 100; i++) // Loops 100 times
                {
                    sw2.WriteLine(random.Next(1, 7)); // Writes a random number between 1 and 6 to the file
                }
            }

            using (StreamReader sr = new StreamReader("C:\\Code Folder\\S1\\Console\\EX20StreamWriter\\Opgave01-02\\test.txt")) // StreamReader reads from a file called test.txt located in the same folder as the .exe file
            {
                List<int> numbers = new List<int>(); // Creates a new list of integers

                string line;
                while ((line = sr.ReadLine()) != null) // Reads the file line by line
                {
                    numbers.Add(int.Parse(line)); // Adds the line to the list of integers
                }

                numbers.Sort(); // Sorts the list of integers

                foreach (int number in numbers) // Loops through the list of integers
                {
                    Console.WriteLine(number); // Prints the number
                }
            }

            Console.ReadKey();
        }
    }
}
