using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activityList = new List<Activity>();

        Running r = new Running(4.8, 30, "03 Nov 2022");
        activityList.Add(r);

        Cycling c = new Cycling(8.3, 30, "03 Nov 2022");
        activityList.Add(c);

        Swimming s = new Swimming(25, 60, "03 Nov 2022");
        activityList.Add(s);

        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}