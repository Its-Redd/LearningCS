using System;

namespace Opgave01_03
{
    internal class Box
    {
        public int Height { get; set; }

        public int Length { get; set; }

        public int Width { get; set; }

        public int Rumfang { get; set; }

        public int Surface { get; set; }

        public Box(int height, int length, int width) //constructor
        {
            Height = height;
            Length = length;
            Width = width;
            Rumfang = height * length * width;
            Surface = (width * 2) + (length * 2) + (height * 2);
        }

        public void PrintInfo()
        {

            Console.WriteLine();
            Console.WriteLine("kassen har følgende mål");
            Console.WriteLine($"Height= {Height} cm  ");
            Console.WriteLine($"Length= {Length} cm  ");

            Console.WriteLine($"Width= {Width} cm  ");
            Console.WriteLine($"rumfanget= {Rumfang} cm3  ");
            Console.WriteLine($"surface= {Surface}cm2  ");

        }

    }
}