using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activity");
        Console.WriteLine(" 4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string answer = Console.ReadLine();

        while (answer != "4")
        {
            if (answer == "1")
            {
                Breathing ba = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                ba.DisplayStartMessage();
                int time = ba.GetActivityTime();
                ba.DisplayBreathingActivity(time);
                ba.DisplayEndMessage();
            }

            else if (answer == "2")
            {
                Reflection ra = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                ra.DisplayStartMessage();
                int time = ra.GetActivityTime();
                ra.DisplayReflectionActivity(time);
                ra.DisplayEndMessage();
            }

            else if (answer == "3")
            {
                Listing la = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                la.DisplayStartMessage();
                int time = la.GetActivityTime();
                la.DisplayListingActivity(time);
                la.DisplayEndMessage();
            }

            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            answer = Console.ReadLine();
        }
    }
}