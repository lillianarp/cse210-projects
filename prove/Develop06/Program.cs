using System;

// EXCEEDED REQUIREMENTS: 1. Added a different type of visual counter for Eternal Goals (see EternalGoal.cs) 2. Turned ListGoalDetails into a new menu item with a method to show goal statistics 3. Made some general formatting edits for better readability. 

namespace EternalQuest // check it out - a name!
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            goalManager.Start(); 
        }
    }
}