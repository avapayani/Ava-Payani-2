using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string input = "29535123p48723487597645723645";
        long totalSum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                string substring = input.Substring(i, j - i + 1);
                if (long.TryParse(substring, out long number)
                    && substring[0] == substring[substring.Length - 1]
                    && substring.Length > 1)
                {
                    Console.Write(input.Substring(0, i));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(substring);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(input.Substring(j + 1, input.Length - (j + 1)));
                    totalSum += number;
                }
            }
        }

        Console.ResetColor();
        Console.WriteLine("\nTotal summa av alla delsträngar som kan omvandlas till tal: " + totalSum);
    }
}
