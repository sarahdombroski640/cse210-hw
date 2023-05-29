public abstract class Activity
{
    private int _minutes;
    private string _date;
    public Activity(int minutes, string date)
    {
        _minutes = minutes;
        _date = date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public abstract string GetActivity();
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return ($"{GetDate()} {GetActivity()} ({GetMinutes()} minutes)- Distance {Double.Round(GetDistance(), 1)} miles, Speed {Double.Round(GetSpeed(), 1)} mph, Pace: {Double.Round(GetPace(), 1)} min per mile");
    }
}