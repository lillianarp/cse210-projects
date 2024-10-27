using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

public class ListingActivity : Activity
{
    // attributes

    private int _count; // i.e. "you listed 4 items"
    private List<string> _prompts;


    // constructor

    public ListingActivity()
    {
        _name = "Listing Activity";
        
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _random = new Random();

        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";
    }

    // methods

    public void Run()
    {
        Console.Clear();

        LogActivity("ListingActivity");

        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");
        GetRandomPrompt();

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userResponses = GetListFromUser(_duration);

        Thread.Sleep(1000);

        Console.WriteLine($"\nYou listed {userResponses.Count} items!");
        ShowSpinner(3);

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        Console.WriteLine($"----{_prompts[index]}----");
    }

    public List<string> GetListFromUser(int durationInSeconds)
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
                _count++; 
            }
        }

        return responses; 
    }

}