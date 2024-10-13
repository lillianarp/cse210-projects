using System;

// Stretch: Only words that are currently visible can be hidden when the user hits enter.
// Exceeded Requirements: Added 2 more scripture references to be randomly presented. 

class Program
{
    static void Main(string[] args)
    {

        // Exceeding Requirements: adding 2 more scriptures to be randomly chosen
        
        // First scripture 
        Reference reference1 = new Reference("Matthew", 5, 14, 16); // reference only, i.e. book & chapter etc.

        string scriptureText1 = "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.";
        Scripture scripture1 = new Scripture(reference1, scriptureText1); // object with reference and text 

        // Second scripture 
        Reference reference2 = new Reference("Genesis", 2, 24); 

        string scriptureText2 = "Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh.";
        Scripture scripture2 = new Scripture(reference2, scriptureText2); 

        // Third scripture 
        Reference reference3 = new Reference("Doctrine and Covenants", 8, 2, 3); 

        string scriptureText3 = "Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.";
        Scripture scripture3 = new Scripture(reference3, scriptureText3); 


        List<Scripture> scriptures = new List<Scripture> { // put these in a list
            scripture1,
            scripture2,
            scripture3
        };

        Random random = new Random(); // make it random
        int randomIndex = random.Next(scriptures.Count);
        Scripture featuredScripture = scriptures[randomIndex];
        
        Reference featuredReference = featuredScripture.GetReference();

        while (!featuredScripture.IsCompletelyHidden())
        {
            Console.Clear(); // so it looks like the words are disappearing from the same printout
            
            Console.WriteLine($"{featuredReference.GetDisplayText()} {featuredScripture.GetDisplayText()}");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break; // this apparently ends the program 
            }
           
            featuredScripture.HideRandomWords(); // between 2 and 5 words hide at a time

        }

        Console.Clear(); 

    }
}