using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        bool listing = true;
        int sum = 0;
        int average = 0;
        int large = 0;

        while (listing)
        {
            Console.Write("Enter Number: ");
            string number_entered = Console.ReadLine();
            int added_number = int.Parse(number_entered);
            numbers.Add(added_number);

            if (added_number == 0)
            {
                listing = false;
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        int all_numbers = numbers.Count - 1;
        average = sum / (all_numbers);
        Console.WriteLine($"Average: {average}");

        Console.WriteLine($"Sum: {sum}");

        numbers.Sort();

        large = numbers[all_numbers];
        Console.WriteLine($"The largest number is: {large}");
    }
}