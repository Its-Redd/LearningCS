using System;
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
        }
    }
}
