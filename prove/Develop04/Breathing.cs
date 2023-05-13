public class Breathing : Activity
{
    public Breathing(string name, string description) : base(name, description)
    {
    }
    public void DisplayBreathingActivity(int time)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        while (startTime < futureTime)
        {
            Console.Write("Breathe in... ");
            Console.Write(">");
            Thread.Sleep(1000);
            Console.Write(">");
            Thread.Sleep(1000);
            Console.Write(">");
            Thread.Sleep(1000);
            Console.Write(">");
            Thread.Sleep(1000);
            Console.WriteLine(">");
            Thread.Sleep(1000);

            Console.Write("Now breathe out... >>>>>");
            Console.Write("\b \b");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Thread.Sleep(1000);
            Console.WriteLine("\b \b");
            Console.WriteLine();

            startTime = DateTime.Now;
        }
    }
}