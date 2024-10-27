
using System.Runtime.CompilerServices;
using System.Security.Principal;

public class Activity
{
    // attributes

    protected string _name;
    protected string _description; // protected so I can modify the display messages from the other classes
    protected int _duration;
    protected Random _random; // leaving this here because... DRY

    

    // constructor

    public Activity()
    {
        _description = ""; // supplied by sub class
        _random = new Random();  
    }

    // methods

    public void DisplayStartingMessage()
    {
        Console.Write($"Welcome to the {_name}.");
        Console.WriteLine($"\n\n{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");

        // EXCEEDING REQUIREMENTS: Error handling for the duration input 

        if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0) // checking that input was a valid, positive integer
        {
            _duration = duration; 
        }
        else
        {
            Console.WriteLine("That doesn't work. Please enter a positive integer.");
            _duration = 30; // default duration in case of error
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You've completed another {_duration} seconds of the {_name}.\n");
    }

    public void ShowSpinner(int seconds)
    {
        // let's build this spinner thing

        List<string>spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");

        foreach (string s in spinnerStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
    public void ShowCountDown(int seconds) 
    {
        // here goes the countdown thing

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i); // put them on the same line
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    // EXCEEDING REQUIREMENTS: Log the number of times each activity was performed 

    private static Dictionary<string, int> activityLog = new Dictionary<string, int>();

    protected void LogActivity(string activityName)
    {
        if (activityLog.ContainsKey(activityName)) // check if the activity is in the dictionary yet (i.e. if it's already been performed or not)
        {
            activityLog[activityName]++;
        }
        else
        {
            activityLog[activityName] = 1;
        }
    }

    public static void DisplayActivityLog()
    {
        Console.WriteLine("\nActivity Log:");
        foreach (var entry in activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }
    
}