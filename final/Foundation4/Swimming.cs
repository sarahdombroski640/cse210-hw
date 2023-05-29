public class Swimming : Activity
{
    private int _laps;
    public Swimming(int laps, int minutes, string date) : base(minutes, date)
    {
        _laps = laps;
    }
    public override string GetActivity()
    {
        return "Swimming";
    }
    public override double GetDistance()
    {
        return (_laps * 50 / 1000 * .62);
    }
    public override double GetSpeed()
    {
        return (_laps * 50 / 1000 * .62) / GetMinutes() * 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / (_laps * 50 / 1000 * .62);
    }
}