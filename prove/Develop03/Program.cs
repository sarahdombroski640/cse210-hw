using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference r = new Reference();
        r.GetRandomReference();
        Scripture s = new Scripture(r, r.GetScriptureText());

        string userInput = "";
        
        while (userInput != "quit" && s.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(s.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish. ");
            userInput = Console.ReadLine();
            s.RemoveWords();    
        }

        Console.WriteLine("Good luck with your memorization!");
        
    }
}