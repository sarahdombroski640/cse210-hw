using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myjournal = new Journal();

        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Load to HTML\n6. Quit");
        Console.Write("What would you like to do? ");
        string answer = Console.ReadLine();

        while (answer != "6")
        {
            if (answer == "1")
            {
                Prompt myPrompts = new Prompt();

                Entry entry = new Entry();

                entry._prompt = myPrompts._GetRandomPrompt();
                Console.WriteLine(entry._prompt);
                Console.Write("> ");
                entry._response = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();

                myjournal._entries.Add(entry);
            }

            if (answer == "2")
            {
                myjournal.DisplayJournalEntries();
            }

            if (answer == "3")
            {
                Console.Write("What is the file: ");
                string filename = Console.ReadLine();
                myjournal.LoadFromCSV(filename);
            }
            
            if (answer == "4")
            {
                Console.Write("What is the file: ");
                string filename = Console.ReadLine();
                myjournal.SaveToCSV(filename);
            }

            if (answer == "5")
            {
                Console.Write("Who is the author (you)? ");
                string author = Console.ReadLine();
                myjournal.SaveToHTML(author);
            }

            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Load to HTML\n6. Quit");
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();
        }
    }
}