using System;
using System.Reflection;

// EXCEEDING REQUIREMENTS: 1. Added error handling to the user's 'duration' input; 2. Added a log of how many times each activity was performed 

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start Breathing Activity");
            Console.WriteLine("    2. Start Reflecting Activity");
            Console.WriteLine("    3. Start Listing Activity");
            Console.WriteLine("    4. Display Activity Log"); // EXCEEDING REQUIREMENTS: Activity Log 
            Console.WriteLine("    5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

        // giving 'switch' a go

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;

                case "4":
                    Activity.DisplayActivityLog();
                    Console.WriteLine("\nPress Enter to return to the menu.");
                    Console.ReadLine(); // let users read the log 
                    break;

                case "5":
                    Console.WriteLine("Good work. Goodbye!");
                    running = false; // exit the loop and end the program
                    break;

                default: 
                    Console.WriteLine("That doesn't work, sorry. Please select a valid option.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}