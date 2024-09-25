using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 11);
        // Console.WriteLine($"Shhhhh! The magic number is: {num}!");

        // Console.Write("How about you give us a magic number? ");
        // string input = Console.ReadLine();
        // int num = int.Parse(input);

        int guess = -1; // so the while loop can run at least once 

        while (guess != num)

        {

            Console.Write("What is your guess? ");
            string guessTheNumber = Console.ReadLine();
            guess = int.Parse(guessTheNumber); // guess has already been declared as an integer; no need to include int again

            if (guess == num)
            {
                Console.WriteLine("Wow. You guessed it!");
            }
            else if (guess < num)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > num)
            {
                Console.WriteLine("Lower");
            }

        }

    }
}