public class Listing : Activity
{
    private string _listingPrompt;
    private List<string> _items;
    public Listing(string name, string description) : base(name, description)
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        
        Random rnd = new Random();
        int randIndex = rnd.Next(prompts.Count);
        _listingPrompt = prompts[randIndex];
    }
    public void DisplayListingActivity(int time)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("--- " + _listingPrompt + " ---");
        
        Console.Write("You may begin in: ");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.WriteLine("\b \b");

        _items = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        while (startTime < futureTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            _items.Add(input);
            startTime = DateTime.Now;
        }
        
        Console.WriteLine("You listed " + _items.Count() + " items!");
        Console.WriteLine();
    }
}