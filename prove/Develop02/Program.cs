using System;
using System.Runtime.CompilerServices;
using System.Security;

// Journal Project | CSE 210

// The nav menu goes here
// if statements for each menu option 

// Exceeding Requirements: Added more conversational text to help users know what is happening as they work through the app, e.g. added 'Here are your journal entries,' and 'Journal loaded from {fileName}', etc.
// Exceeding Requirements; 

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // new object based on the class in Journal.cs 
        PromptGenerator promptGenerator = new PromptGenerator(); // new promptGenerator object 

        bool quit = false; // declaring the datatype for 'quit' 

        while (!quit)
        {
            // here comes the menu
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string option = Console.ReadLine(); // no need to convert to int; keep the option numbers strings

            if (option == "1")
            {
                Console.WriteLine("");
                // create a new entry object
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("dd/MM/yyyy");

                // random prompt & write 
                string randomPrompt = promptGenerator.GetRandomPrompt(); // call the method inside the case
                newEntry._promptText = randomPrompt; // variable from Entry class
                Console.WriteLine($"Date: {newEntry._date} - Prompt: {randomPrompt}");
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine(); // variable also from Entry class

                // add entry to journal
                journal.AddEntry(newEntry);
                Console.WriteLine("");
                Console.WriteLine("Entry saved.");
                Console.WriteLine("");

            }
            else if (option == "2")
            {
                // display all entries
                Console.WriteLine("");
                Console.WriteLine("Here are all your journal entries:");
                Console.WriteLine("");
                journal.DisplayAll();
                Console.WriteLine($"You have {journal._entries.Count} journal entries."); // Exceeding Requirements: Shows the user how many journal entries they have
                Console.WriteLine("");
            }
            else if (option == "3")
            {
                // load from file
                Console.Write("What filename would you like to load from? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);

                Console.WriteLine("");
                Console.WriteLine($"Journal loaded from {fileName}."); // Exceeding Requirements: Text guides to help users confirm what the program is doing
                Console.WriteLine("");
            }
            else if (option == "4")
            {
                // save to file
                Console.Write("What filename would you like to save to? ");
                string userFileName = Console.ReadLine();

                if (File.Exists(userFileName)) // https://learn.microsoft.com/en-us/dotnet/api/system.io.file.exists?view=net-8.0
                {
                    Console.WriteLine($"The file {userFileName} already exists. Would you like to overwrite it? (y/n) "); // Exceeding Requirments: Check if the userFileName already exists and if the user wants to overide it; otherwise, cancels the save.
                    string overwrite = Console.ReadLine();
                    if (overwrite.ToLower() != "y") // https://learn.microsoft.com/en-us/dotnet/api/system.string.tolower?view=net-8.0
                    {
                        Console.WriteLine("Save cancelled.");
                    }
                }

                journal.SaveToFile(userFileName);

                Console.WriteLine("");
                Console.WriteLine($"Journal saved to {userFileName}.");
                Console.WriteLine("");
            }
            else if (option == "5")
            {
                // exit the program 
                quit = true; // break the loop 
                Console.WriteLine("See you again next time");
                Console.WriteLine("");
            }

        }




    }
}