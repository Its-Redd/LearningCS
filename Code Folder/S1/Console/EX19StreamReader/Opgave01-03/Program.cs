using System;

namespace Opgave01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("C:\\Code Folder\\S1\\Console\\EX19StreamReader\\Opgave01-03\\Values.txt");

            int sum = 0; // sum of values read
            int count = 0; // number of values read

            while (!sr.EndOfStream) // while not at the end of the file read a line
            {
                string line = sr.ReadLine();
                int value = int.Parse(line);
                sum += value;
                count++;
            }
            sr.Close(); // close the file

            //Print the sum and average
            double average = (double)sum / count; // average of values read in a more precise value
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine($"Gennemsnit: {average}");

            //-------------------------------------------------------------------------------------
            System.IO.StreamReader sr2 = new System.IO.StreamReader("C:\\Code Folder\\S1\\Console\\EX19StreamReader\\Opgave01-03\\.txt");


            // Visual Studio slettede det meste lige da jeg blev færdig.......................
            // Jeg nægter at lave det igen da jeg har lavet mange opgaver flere gange.
            // Jeg er allerede bagud med opgaverne og har ikke tid til at lave det igen.

            // Visual Studio deleted most of it as soon as I finished.......................
            // I refuse to do it again as I have done many assignments several times.
            // I am already behind with the assignments and do not have time to do it again.


            Console.ReadKey();
        }
    }
}
