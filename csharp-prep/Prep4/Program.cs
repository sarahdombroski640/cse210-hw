using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = 1;

        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int value in numbers)
        {
            sum += value;
        }
        Console.WriteLine($"The sum is: {sum}");

        float total = numbers.Count;
        float average = ((float)sum) / total;
        Console.WriteLine($"The average is: {average}");


        int max = numbers[0];

        foreach (int value in numbers)
        {
            if (value > max)
            {
                max = value;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}