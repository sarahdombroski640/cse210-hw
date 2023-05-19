using System.IO;
public abstract class Goals
{
    protected string _name;
    protected string _description;
    private int _points;
    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public virtual void DisplayGoal()
    {
    }
    public abstract List<string> RecordEvent(List<string> goalsList, int accomplished, int goalPoints);
    public abstract bool IsComplete();
}