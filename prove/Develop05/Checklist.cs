public class Checklist : Goals
{
    private int _bonusPoints;
    private int _goalCompletion;
    private int _progress;
    private string _fullGoal;
    public Checklist(string name, string description, int points, int bonusPoints, int goalCompletion, int progress) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _goalCompletion = goalCompletion;
        _progress = progress;

        _fullGoal = ($"ChecklistGoal~|~{name}~|~{description}~|~{points}~|~{bonusPoints}~|~{goalCompletion}~|~{progress}");
    }
    public string GetFullGoal()
    {
        return _fullGoal;
    }
    public override void DisplayGoal()
    {
        base.DisplayGoal();

        if (_progress == _goalCompletion)
        {
            Console.WriteLine($"[X] {_name} ({_description}) -- Currently completed {_progress}/{_goalCompletion}");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description}) -- Currently completed {_progress}/{_goalCompletion}");
        }
    }
    public override List<string> RecordEvent(List<string> goalsList, int accomplished, int goalPoints)
    {
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You have earned {goalPoints + _bonusPoints} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");
        }
        
        goalsList.RemoveAt(accomplished);
        goalsList.Insert(accomplished, _fullGoal);
        
        return goalsList;
    }
    public override bool IsComplete()
    {
        if (_goalCompletion == _progress)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}