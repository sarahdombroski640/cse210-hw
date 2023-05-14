public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityTime;
    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }
    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }
    public int GetActivityTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        _activityTime = int.Parse(time);
        return _activityTime;
    }
    public void DisplayEndMessage(int activityCount, int bactivityCount, int ractivityCount, int lactivityCount)
    {
        Console.WriteLine("Well Done!");
        DisplaySpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed {_activityTime} seconds of the {_activityName}");
        Console.WriteLine();
        Console.WriteLine("You have completed " + activityCount + " activites!");
        Console.WriteLine("You have completed " + bactivityCount + " breathing activites!");
        Console.WriteLine("You have completed " + ractivityCount + " reflecting activites!");
        Console.WriteLine("You have completed " + lactivityCount + " listing activites!");
        DisplaySpinner();
    }
    public void DisplaySpinner()
    {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
    }
}