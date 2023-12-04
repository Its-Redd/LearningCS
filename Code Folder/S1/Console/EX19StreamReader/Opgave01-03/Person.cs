using System;

namespace Opgave01_03
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)  //constructor
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Personen har følgende navn og alder");
            Console.WriteLine($"Name= {Name}  ");
            Console.WriteLine($"Age= {Age}  ");
        }
    }
}
