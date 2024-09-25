using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What what is your grade percentage? ");
        string grade = Console.ReadLine(); // reminder: Console.ReadLine always returns a string
        int num = int.Parse(grade);

        string letter = ""; // assign an empty value just in case 

        if (num >= 90)
        {
            // Console.WriteLine("You got an A!");
            letter = "A";
        }
        else if (num >= 80)
        {
            // Console.WriteLine("You got a B");
            letter = "B";
        }
        else if (num >= 70)
        {
            // Console.WriteLine("You got a C.");
            letter = "C";
        }
        else if (num >= 60)
        {
            // Console.WriteLine("You got a D.");
            letter = "D";
        }
        else if (num < 60)
        {
            // Console.WriteLine("You got an F.");
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}.");

        if (num <= 69)
        {
            Console.WriteLine("Too bad you didn't pass the class. Better luck next time.");
        }
        else if (num >= 70)
        {
            Console.WriteLine("You passed the class! Good work :) ");
        }
    }
}