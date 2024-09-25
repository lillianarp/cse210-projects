using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers. Type 0 when you're done.");

        List<int> numbers = new List<int>();
        int num = -1; // can't use an empty string here because... not string.

        while (num != 0)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            num = int.Parse(number); // int is already declared outside the loop 

            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        int sum = 0;
        foreach (int number in numbers) // can't use 'num' again because it was declared outside of the previous while loop (so, not contained to that loop)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
        

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

        // Stretch Challenge

        int smallest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest)
            {
                smallest = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallest}");

    }
}