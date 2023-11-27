using System;

public class BowlingCompetition
{
    public static void Main()
    {
        Console.Write("Indtast antallet af deltagere: ");
        int antalDeltagere = int.Parse(Console.ReadLine());

        string[] names = new string[antalDeltagere];
        int[] point = new int[antalDeltagere];

        for (int i = 0; i < antalDeltagere; i++)
        {
            Console.Write($"Indtast deltager {i + 1}: ");
            names[i] = Console.ReadLine();

            Console.Write("Indtast antal point: ");
            point[i] = int.Parse(Console.ReadLine());

            Console.Clear();
        }

        int maxPointsIndex = FindMaxPointIndex(point);
        int minPointsIndex = FindMinPointIndex(point);
        int longestNameIndex = FindLongestNameIndex(names);
        int shortestNameIndex = FindShortestNameIndex(names);

        Console.WriteLine($"Vinderen er: {names[maxPointsIndex]} med {point[maxPointsIndex]} point.");
        Console.WriteLine($"Taberen er: {names[minPointsIndex]} med {point[minPointsIndex]} point.");
        Console.WriteLine($"Deltageren med det længste navn er: {names[longestNameIndex]}.");
        Console.WriteLine($"Deltageren med det korteste navn er: {names[shortestNameIndex]}.");

        Console.WriteLine("\nAlle deltagere:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();

    }

    static int FindMaxPointIndex(int[] points)
    {
        int maxIndex = 0;
        for (int i = 1; i < points.Length; i++)
        {
            if (points[i] > points[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    static int FindMinPointIndex(int[] points)
    {
        int minIndex = 0;
        for (int i = 1; i < points.Length; i++)
        {
            if (points[i] < points[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }

    static int FindLongestNameIndex(string[] names)
    {
        int longestIndex = 0;
        for (int i = 1; i < names.Length; i++)
        {
            if (names[i].Length > names[longestIndex].Length)
            {
                longestIndex = i;
            }
        }
        return longestIndex;
    }

    static int FindShortestNameIndex(string[] names)
    {
        int shortestIndex = 0;
        for (int i = 1; i < names.Length; i++)
        {
            if (names[i].Length < names[shortestIndex].Length)
            {
                shortestIndex = i;
            }
        }
        return shortestIndex;
    }
}