
public class BreathingActivity : Activity
{
    // attributes - none

    // constructor

    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n";
    }

    // method

    public void Run()
    {
        Console.Clear();

        LogActivity("BreathingActivity");
        
        DisplayStartingMessage();

        // put this in a loop - for as many seconds as was inputted by the user in _duration

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(8);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }
}