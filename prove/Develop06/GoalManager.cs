
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
namespace EternalQuest
{
    public class GoalManager
    {
        // This is a separate class, not a base - it's similar to Program.cs 

        // attributes

        private List<Goal> _goals;
        private int _score;

        // constructor

        public GoalManager()
        {
            _score = 0;
            _goals = new List<Goal>(); 
        }

        // MAIN MENU

        public void Start()
        {
            bool quit = false;
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"You have {_score} points.");
                Console.WriteLine();
                Console.WriteLine("Menu Options");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Events");
                Console.WriteLine("6. List Goal Details"); // EXCEEDING REQUIREMENTS: New menu item
                Console.WriteLine("7. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalNames();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        ListGoalDetails(); // re-thinking what this method does
                        break;
                    case "7":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("That doesn't work, sorry. Please try again.");
                        break;
                }
            }
        }

        // methods
        // this one includes another menu 

        public void CreateGoal()
        {
            Console.WriteLine();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string goalType = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What's a short description of your goal: ");
            string description = Console.ReadLine();

            Console.Write("How many points would you like associated with this goal? ");
            string points = Console.ReadLine();

            Goal newGoal; // to reference the different types of goals in the subclasses; it's a polymorphism thing!

            switch (goalType)
            {
                case "1":
                    newGoal = new SimpleGoal(name, description, points);
                    break;
                case "2":
                    newGoal = new EternalGoal(name, description, points);
                    break;
                case "3":
                    Console.Write("How many times must this goal be completed to finish? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What bonus points would you like upon completion? ");
                    int bonus = int.Parse(Console.ReadLine());
                    newGoal = new ChecklistGoal(name, description, points, 0, target, bonus);
                    break;
                default: 
                    Console.WriteLine("That's not a choice, sorry. Returning to main menu.");
                    return;
            }

            _goals.Add(newGoal);
            Console.WriteLine();
            Console.WriteLine($"Your goal '{name}' has been added to your list!" );
            
            Console.WriteLine();
            Console.Write("Press any key to return to the main menu...");
            Console.ReadKey(); 
        }

        private void ListGoalNames()
        {
            Console.WriteLine($"Your goals are:");

            if (_goals.Count == 0)
            {
                Console.WriteLine("You haven't made any goals yet.");
            }
            else
            {
                int count = 1;    
                foreach (Goal goal in _goals) // list all the goals so far
                {
                    string statusBracket = goal.IsComplete() ? "[X]" : "[ ]";
                    
                    Console.WriteLine($"{count}. {statusBracket} {goal.GetStringRepresentation()}");
                    count++;
                }
            }

            Console.Write("Press any key to return to main menu...");
            Console.ReadKey();
        }

        private void ListGoalDetails() // hmmm... let's put some goal stats in here.
        {
            Console.WriteLine();
            Console.WriteLine("An Overview of Your Goals:");
            Console.WriteLine();

            if (_goals.Count == 0)
            {
                Console.WriteLine("You haven't made any goals yet.");
                Console.Write("Press any key to return to the main menu...");
                Console.ReadKey();
                return;
            }

            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"Name: {goal.ShortName}");
                Console.WriteLine($"Description: {goal.Description}");
                Console.WriteLine($"Points: {goal.Points}");

                if (goal is SimpleGoal simpleGoal)
                {
                    Console.WriteLine($"Completed: {simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    Console.WriteLine($"Progress: {eternalGoal.GetProgressRepresentation()}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    Console.WriteLine($"Bonus Points: {checklistGoal.Bonus}");
                    Console.WriteLine($"Target: {checklistGoal.Target}");
                    Console.WriteLine($"Currently Completed: {checklistGoal.AmountCompleted}/{checklistGoal.Target}");
                }

                Console.WriteLine(); // Blank line between goals for readability
            }

            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
                
        }
        
        private void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);

                foreach (Goal goal in _goals)
                {
                    if (goal is SimpleGoal simpleGoal)
                    {
                        writer.WriteLine($"SimpleGoal: {simpleGoal.ShortName}, {simpleGoal.Description}, {simpleGoal.Points}, {simpleGoal.IsComplete()}");
                    }
                    else if (goal is EternalGoal eternalGoal)
                    {
                        writer.WriteLine($"EternalGoal: {eternalGoal.ShortName}, {eternalGoal.Description}, {eternalGoal.Points}");
                    }
                    else if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine($"checklistGoal: {checklistGoal.ShortName}, {checklistGoal.Description}, {checklistGoal.Points}, {checklistGoal.Bonus}, {checklistGoal.Target}, {checklistGoal.AmountCompleted}");
                    }
                }
            }

            Console.WriteLine("Goals have been saved successfully!");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }

        private void LoadGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("We can't find that file. Please check the filename and try again.");
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                return;
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line=reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string goalType = parts[0].Trim();
                    string[] details = parts[1].Split(',');

                    if (goalType == "SimpleGoal")
                    {
                        string name = details[0].Trim();
                        string description = details[1].Trim();
                        string points = details[2].Trim();
                        bool isComplete = bool.Parse(details[3].Trim());

                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        if (isComplete)
                        {
                            simpleGoal.RecordEvent(); // Mark as complete if true
                        }
                        _goals.Add(simpleGoal);
                    }
                    else if(goalType == "EternalGoal")
                    {
                        string name = details[0].Trim();
                        string description = details[1].Trim();
                        string points = details[2].Trim();

                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string name = details[0].Trim();
                        string description = details[1].Trim();
                        string points = details[2].Trim();
                        int bonus = int.Parse(details[3].Trim());
                        int target = int.Parse(details[4].Trim());
                        int amountCompleted = int.Parse(details[5].Trim());

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                        _goals.Add(checklistGoal);
                    }
                }
            }
            Console.WriteLine("Goals have been loaded successfully!");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }   

        public void RecordEvent()
        {
            Console.WriteLine("Record an Event.");
            if (_goals.Count == 0)
            {
                Console.WriteLine("You haven't made any goals yet");
                Console.Write("Press any key to return to the main menu...");
                Console.ReadKey();
                return;
            }

            int count = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{count}. {goal.ShortName}");
                count++;
            }

            Console.Write("Which goal did you accomplish? ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
            {
                Goal selectedGoal = _goals[goalIndex - 1]; // zero based index
                selectedGoal.RecordEvent();

                int pointsEarned = int.Parse(selectedGoal.Points);
                _score += pointsEarned;
                
                Console.WriteLine();
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points");
            }
            else
            {
                Console.Write("That doesn't work, sorry. Please try again.");
            }

            Console.WriteLine();
            Console.Write("Press any key to return to the main menu...");
            Console.ReadKey();            
        }

    }

}