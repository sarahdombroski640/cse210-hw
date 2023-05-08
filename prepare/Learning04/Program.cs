using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Sarah", "Fractions");
        string summary = a.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine();

        MathAssignment ma = new MathAssignment("Sarah", "Fractions", "7.3", "8-19");
        string newsummary = ma.GetSummary();
        string hmwklist = ma.GetHomeworkList();
        Console.WriteLine(newsummary);
        Console.WriteLine(hmwklist);
        Console.WriteLine();

        WritingAssignment wa = new WritingAssignment("Sarah", "European History", "The Causes of WWII");
        string anothersummary = wa.GetSummary();
        string writinglist = wa.GetWritingInformation();
        Console.WriteLine(anothersummary);
        Console.WriteLine(writinglist);
    }
}