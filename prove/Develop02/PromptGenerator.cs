using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator() // <- called a 'constructor' 
    {
        _prompts.Add("What am I the most proud of accomplishing today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What am I the most grateful for today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    // Method for random prompt:
    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "Sorry, no prompts left.";
        }

        Random random = new Random(); // built-in method https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp
        int index = random.Next(_prompts.Count); 
        return _prompts[index];
    }
}