public class Reflection : Activity
{
    private string _reflectionQuestion;
    public Reflection(string name, string description) : base(name, description)
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        
        Random rnd = new Random();
        int randIndex = rnd.Next(prompts.Count);
        _reflectionQuestion = prompts[randIndex];
    }
    public void DisplayReflectionActivity(int seconds)
    {
        List<string> prompts = new List<string>();
        prompts.Add("Why was this experience meaningful to you?");
        prompts.Add("Have you ever done anything like this before?");
        prompts.Add("How did you get started?");
        prompts.Add("How did you feel when it was complete?");
        prompts.Add("What made this time different than other times when you were not as successful?");
        prompts.Add("What is your favorite thing about this experience?");
        prompts.Add("What could you learn from this experience that applies to other situations?");
        prompts.Add("What did you learn about yourself through this experience?");
        prompts.Add("How can you keep this experience in mind in the future?");

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
        Console.WriteLine();
        Console.WriteLine("--- " + _reflectionQuestion + " ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (startTime < futureTime)
        {
            Random rnd = new Random();
            int randIndex = rnd.Next(prompts.Count);
            string randomPrompt = prompts[randIndex];
            Console.Write("> " + randomPrompt);
            DisplaySpinner();
            DisplaySpinner();
            Console.WriteLine();
            startTime = DateTime.Now;
        }

        Console.WriteLine();
    }
}