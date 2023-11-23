using System;

namespace Opgave07
{
    internal class Program
    {
        public string[] names = new string[7]; // Adjusted array size

        static void Main(string[] args)
        {
            Program program = new Program(); // Create an instance to access non-static method
            program.NameArray();
        }

        public void NameArray()
        {
            //7.4
            int id;

            names[1] = "Henrik";
            names[2] = "Jesper";
            names[3] = "Jens";
            names[4] = "Jan";
            names[5] = "Dea";
            names[6] = "Mads";
            names[0] = "Kenneth";

            while (true)
            {
                Console.Write("Indtast ID på det navn du skal bruge (0-6): ");
                if (int.TryParse(Console.ReadLine(), out id) && id >= 0 && id <= 6)
                {
                    Console.WriteLine(names[id]);
                }
                else
                {
                    Console.WriteLine("Dit input matcher ikke en brugers ID, prøv igen");
                }
            }
        }
    }
}