using System;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        List<string> goalsList = new List<string>();
        Saving s = new Saving();

        Console.WriteLine($"You have {points} points.");
        
        int level = s.Level(points);
        string title = s.Title(level);
        int pointsToNext = s.PointsToNext(points);
        s.DisplayLevel(level, pointsToNext, title);
        Console.WriteLine();
        
        Console.Write(@"Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: ");
        string choice = Console.ReadLine();
        Console.WriteLine();
        
        while (choice != "6")
        {
            if (choice == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");

                Console.Write("Which type of goal would you like to choose? ");
                string goalType = Console.ReadLine();

                if (goalType == "1")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string associatedPoints = Console.ReadLine();
                    int awardedPoints = int.Parse(associatedPoints);

                    Simple sg = new Simple(name, description, awardedPoints, false);
                    goalsList.Add(sg.GetFullGoal());
                }
                else if (goalType == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string associatedPoints = Console.ReadLine();
                    int awardedPoints = int.Parse(associatedPoints);

                    Eternal eg = new Eternal(name, description, awardedPoints);
                    goalsList.Add(eg.GetFullGoal());
                }
                else
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string associatedPoints = Console.ReadLine();
                    int awardedPoints = int.Parse(associatedPoints);
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string completion = Console.ReadLine();
                    int goalCompletion = int.Parse(completion);
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string bonus = Console.ReadLine();
                    int bonusPoints = int.Parse(bonus);

                    Checklist cg = new Checklist(name, description, points, bonusPoints, goalCompletion, 0);
                    goalsList.Add(cg.GetFullGoal());
                }
            }
            else if (choice == "2")
            {
                for (int i = 0; i < goalsList.Count; i++)
                {
                    string line = goalsList[i];
                    string[] parts = line.Split("~|~");

                    string goalType = parts[0];
                    string goalTitle = parts[1];
                    string goalDescription = parts[2];
                    string gpoints = parts[3];
                    int goalPoints = int.Parse(gpoints);
                    
                    if (goalType == "SimpleGoal")
                    {
                        string gComplete = parts[4];
                        bool goalComplete = bool.Parse(gComplete);
                        Simple sg = new Simple(goalTitle, goalDescription, goalPoints, goalComplete);
                        Console.Write($"{i+1}. ");
                        sg.DisplayGoal();
                    }
                    else if (goalType == "EternalGoal")
                    {
                        Eternal eg = new Eternal(goalTitle, goalDescription, goalPoints);
                        Console.Write($"{i+1}. ");
                        eg.DisplayGoal();
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string bonus = parts[4];
                        int goalBonus = int.Parse(bonus);
                        string completion = parts[5];
                        int goalCompletion = int.Parse(completion);
                        string progress = parts[6];
                        int goalProgress = int.Parse(progress);
                        Checklist cg = new Checklist(goalTitle, goalDescription, goalPoints, goalBonus, goalCompletion, goalProgress);
                        Console.Write($"{i+1}. ");
                        cg.DisplayGoal();
                    }
                }
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                s.SaveToCSV(fileName, points, goalsList);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                int newPoints = s.LoadFromCSV(fileName, goalsList);
                points += newPoints;
            }
            else if (choice == "5")
            {
                Console.Write("Which goal did you accomplish? ");
                string ag = Console.ReadLine();
                int acc = int.Parse(ag);
                int accomplished = acc - 1;

                string accomplishedGoal = goalsList.ElementAt(accomplished);

                string line = goalsList[accomplished];
                string[] parts = line.Split("~|~");

                string goalType = parts[0];
                string goalTitle = parts[1];
                string goalDescription = parts[2];
                string gpoints = parts[3];
                int goalPoints = int.Parse(gpoints);
                
                if (goalType == "SimpleGoal")
                {
                    points += goalPoints;
                    bool goalComplete = true;
                    Simple sg = new Simple(goalTitle, goalDescription, goalPoints, goalComplete);
                    goalsList = sg.RecordEvent(goalsList, accomplished, goalPoints);
                }
                else if (goalType == "EternalGoal")
                {
                    points += goalPoints;
                    Eternal eg = new Eternal(goalTitle, goalDescription, goalPoints);
                    goalsList = eg.RecordEvent(goalsList, accomplished, goalPoints);
                }
                else if (goalType == "ChecklistGoal")
                {
                    string bonus = parts[4];
                    int goalBonus = int.Parse(bonus);
                    string completion = parts[5];
                    int goalCompletion = int.Parse(completion);
                    string progress = parts[6];
                    int goalProgress = int.Parse(progress);
                    
                    points += goalPoints;
                    goalProgress ++;
                    if (goalCompletion == goalProgress)
                    {
                        points += goalBonus;
                    }
                    Checklist cg = new Checklist(goalTitle, goalDescription, goalPoints, goalBonus, goalCompletion, goalProgress);
                    goalsList = cg.RecordEvent(goalsList, accomplished, goalPoints);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"You have {points} points.");
            level = s.Level(points);
            title = s.Title(level);
            pointsToNext = s.PointsToNext(points);
            s.DisplayLevel(level, pointsToNext, title);
            Console.WriteLine();
            Console.Write(@"Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: ");

            choice = Console.ReadLine();
            Console.WriteLine();
        }
    }
}