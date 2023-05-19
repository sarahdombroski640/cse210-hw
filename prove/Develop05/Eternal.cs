public class Eternal : Goals
{
    private string _fullGoal;
    public Eternal(string name, string description, int points) : base(name, description, points)
    {
        _fullGoal = ($"EternalGoal~|~{name}~|~{description}~|~{points}");
    }
    public string GetFullGoal()
    {
        return _fullGoal;
    }
    public override void DisplayGoal()
    {
        base.DisplayGoal();

        Console.WriteLine($"[ ] {_name} ({_description})");
    }
    public override List<string> RecordEvent(List<string> goalsList, int accomplished, int goalPoints)
    {
        goalsList.RemoveAt(accomplished);
        goalsList.Insert(accomplished, _fullGoal);
        Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");
        return goalsList;
    }
    public override bool IsComplete()
    {
        return false;
    }
}