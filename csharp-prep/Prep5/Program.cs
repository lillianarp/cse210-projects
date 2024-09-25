using System;

class Program
{
    static void Main(string[] args)
    {
        // this function is meant to call each of these functions saving the return values and passing data to them as necessary.
        DisplayMessage();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);

        DisplayResult(name, square);

    }

    static void DisplayMessage() // this function performs an action but doesn't return anything, so 'void' 
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName() // shouldn't this be void as well? Oh wait.. I need the name from this function, so ...'string'. 
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name; // like in Python 
    }
    static int PromptUserNumber() // need a return statement here, too 
    {
        Console.Write("Please enter your favourite number: ");
        string faveNumber = Console.ReadLine();
        int number = int.Parse(faveNumber);
        return number;
    }
    static int SquareNumber(int number) // return statement?
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square) // what parameters go here? 
    {
        Console.WriteLine($"{name}, the sqare of your number is {square}");
    }
}