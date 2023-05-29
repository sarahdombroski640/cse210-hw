using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("525 S Center St", "Rexburg", "Idaho", "United States");
        Lecture l = new Lecture("Hank Smith", 200, "Finding Peace in Christ", "Hank Smith will give his advice on how we can find peace in our life through Jesus Christ", "June 18, 2023", "7:00 PM", a1);

        Console.Clear();
        Console.WriteLine("Lecture:");
        Console.WriteLine("Standard:");
        Console.WriteLine(l.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full:");
        Console.WriteLine(l.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short:");
        Console.WriteLine(l.GetShortDescription());
        Console.WriteLine();


        Address a2 = new Address("345 S 3rd W", "Rexburg", "Idaho", "United States");
        Reception r = new Reception("mydoghasfleas@gmail.com", "Bob and Mary's Wedding", "Bob and Mary are getting married! Join us for the reception.", "July 23, 2023", "6:00 - 8:00 PM", a2);

        Console.WriteLine("Reception:");
        Console.WriteLine("Standard:");
        Console.WriteLine(r.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full:");
        Console.WriteLine(r.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short:");
        Console.WriteLine(r.GetShortDescription());
        Console.WriteLine();



        Address a3 = new Address("S 2nd W & 3rd W", "Rexburg", "Idaho", "United States");
        Outdoor o = new Outdoor("Rainy", "Mud Volleyball", "We're going to play mud volleyball at the courts! It will be the perfect weather for it!", "May 30, 2023", "2:00 PM", a3);

        Console.WriteLine("Outdoor:");
        Console.WriteLine("Standard:");
        Console.WriteLine(o.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full:");
        Console.WriteLine(o.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short:");
        Console.WriteLine(o.GetShortDescription());
    }
}