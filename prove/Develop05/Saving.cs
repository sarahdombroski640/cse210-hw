public class Saving
{
    public int LoadFromCSV(string filename, List<string> list)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        string tPoints = lines[0];
        int totalPoints = int.Parse(tPoints);

        for (int i = 1; i < lines.Length; i++)
        {
            string goal = lines[i];

            list.Add(goal);
        }
        
        return totalPoints;
    }
    public void SaveToCSV(string fileName, int points, List<string> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(points);

            foreach (string goal in goals)
            {
                outputFile.WriteLine(goal);
            }
        }
    }
    public int Level(int points)
    {
        if (points < 50)
        {
            return 1;
        }
        else if (points < 100)
        {
            return 2;
        }
        else if (points < 150)
        {
            return 3;
        }
        else if (points < 200)
        {
            return 4;
        }
        else if (points < 250)
        {
            return 4;
        }
        else if (points < 300)
        {
            return 5;
        }
        else if (points < 350)
        {
            return 6;
        }
        else if (points < 400)
        {
            return 7;
        }
        else if (points < 450)
        {
            return 8;
        }
        else if (points < 500)
        {
            return 9;
        }
        else if (points < 550)
        {
            return 10;
        }
        else if (points < 600)
        {
            return 11;
        }
        else if (points < 650)
        {
            return 12;
        }
        else if (points < 700)
        {
            return 13;
        }
        else if (points < 750)
        {
            return 14;
        }
        else if (points < 800)
        {
            return 15;
        }
        else if (points < 850)
        {
            return 16;
        }
        else if (points < 900)
        {
            return 17;
        }
        else if (points < 950)
        {
            return 18;
        }
        else if (points < 1000)
        {
            return 19;
        }
        else
        {
            return 20;
        }
    }
    public string Title(int level)
    {
        if (level < 4)
        {
            return "Novice";
        }
        else if (level < 8)
        {
            return "Perseverer";
        }
        else if (level < 12)
        {
            return "Apprentice of the Art";
        }
        else if (level < 16)
        {
            return "Expert Goal Setter";
        }
        else if (level < 20)
        {
            return "Master of Goals";
        }
        else
        {
            return "Ultimate Champion";
        }
    }
    public int PointsToNext(int points)
    {
        if (points < 50)
        {
            return 50 - points;
        }
        else if (points < 100)
        {
            return 100 - points;
        }
        else if (points < 150)
        {
            return 150 - points;
        }
        else if (points < 200)
        {
            return 200 - points;
        }
        else if (points < 250)
        {
            return 250 - points;
        }
        else if (points < 300)
        {
            return 300 - points;
        }
        else if (points < 350)
        {
            return 350 - points;
        }
        else if (points < 400)
        {
            return 400 - points;
        }
        else if (points < 450)
        {
            return 450 - points;
        }
        else if (points < 500)
        {
            return 500 - points;
        }
        else if (points < 550)
        {
            return 550 - points;
        }
        else if (points < 600)
        {
            return 600 - points;
        }
        else if (points < 650)
        {
            return 650 - points;
        }
        else if (points < 700)
        {
            return 700 - points;
        }
        else if (points < 750)
        {
            return 750 - points;
        }
        else if (points < 800)
        {
            return 800 - points;
        }
        else if (points < 850)
        {
            return 850 - points;
        }
        else if (points < 900)
        {
            return 900 - points;
        }
        else if (points < 950)
        {
            return 950 - points;
        }
        else if (points < 1000)
        {
            return 1000 - points;
        }
        else
        {
            return 0;
        }
    }
    public void DisplayLevel(int level, int pointsToNext, string Title)
    {
        Console.WriteLine($"You are level {level} - {Title}.");
        Console.WriteLine($"Keep going! You have {pointsToNext} points until you level up.");
    }
}