using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Proverbs", "3", "5", "6");
        Scripture s = new Scripture(r, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        string userInput = "";
        
        while (userInput != "quit" && s.HasWordsLeft() == true)
        {
            Console.Clear();
            // Display Scripture
            Console.WriteLine(s.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish. ");
            userInput = Console.ReadLine();
            s.RemoveWords();    
        }

        Console.WriteLine("Good luck with your memorization!");
        
    }
}