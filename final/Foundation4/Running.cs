public class Running : Activity
{
    private double _distance;
    public Running(double distance, int minutes, string date) : base(minutes, date)
    {
        _distance = distance;
    }
    public override string GetActivity()
    {
        return "Running";
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        return (GetMinutes() / _distance);
    }
}