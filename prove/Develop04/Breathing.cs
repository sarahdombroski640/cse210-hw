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
            Console.Clear();
            Console.WriteLine("Breathe in...");
            Console.WriteLine();
            
            Console.Write(">");
            Thread.Sleep(50);
            Console.Write(">");
            Thread.Sleep(50);
            Console.Write(">");
            Thread.Sleep(100);
            Console.Write(">");
            Thread.Sleep(150);
            Console.Write(">");
            Thread.Sleep(200);
            Console.Write(">");
            Thread.Sleep(250);
            Console.Write(">");
            Thread.Sleep(300);
            Console.Write(">");
            Thread.Sleep(400);
            Console.Write(">");
            Thread.Sleep(600);
            Console.Write(">");
            Thread.Sleep(800);
            Console.Write(">");
            Thread.Sleep(1000);
            Console.Write(">");
            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("Breathe in...");

            Console.WriteLine("Now breathe out...");
            Console.Write(">>>>>>>>>>>>>");
            Console.Write("\b \b");
            Thread.Sleep(50);
            Console.Write("\b \b");
            Thread.Sleep(50);
            Console.Write("\b \b");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Thread.Sleep(400);
            Console.Write("\b \b");
            Thread.Sleep(600);
            Console.Write("\b \b");
            Thread.Sleep(800);
            Console.Write("\b \b");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine();

            startTime = DateTime.Now;
        }
    }
}