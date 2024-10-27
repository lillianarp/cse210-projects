
public class ReflectingActivity : Activity
{
    // attributes

    private List<string> _prompts;
    private List<string> _questions;

    // constructor

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";

        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // methods

    public void Run()
    {
        Console.Clear();

        LogActivity("ReflectingActivity");

        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:\n");

        Thread.Sleep(2000);

        DisplayPrompt();

        Thread.Sleep(3000);

        Console.Write("When you have something in mind, press ENTER to continue.");
        Console.ReadLine(); // 'listen' for the ENTER 
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\n");

        Thread.Sleep(2000);

        Console.Write("You may begin in...");
        ShowCountDown(8);

        Console.Clear();

        DisplayQuestions();

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index]; 
    }
    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index]; 
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
    }
    public void DisplayQuestions()
    {           
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
        Console.Write($"> {GetRandomQuestion()}\n");
        ShowSpinner(10);
        }

        Console.WriteLine();
    }
    
}