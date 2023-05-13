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

            Console.Write("Now breathe out... ");
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
            Console.WriteLine();

            startTime = DateTime.Now;
        }
    }
}