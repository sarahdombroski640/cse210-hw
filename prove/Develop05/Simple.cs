public class Simple : Goals
{
    private bool _completed;
    private string _fullGoal;
    public Simple(string name, string description, int points, bool completed) : base(name, description, points)
    {
        _completed = completed;

        _fullGoal = ($"SimpleGoal~|~{name}~|~{description}~|~{points}~|~{completed}");
    }
    public string GetFullGoal()
    {
        return _fullGoal;
    }
    public override void DisplayGoal()
    {
        base.DisplayGoal();

        if (_completed == false)
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"[X] {_name} ({_description})");
        }
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
        return _completed;
    }
}