public class Cycling : Activity
{
    private double _speed;
    public Cycling(double speed, int minutes, string date): base(minutes, date)
    {
        _speed = speed;
    }
        public override string GetActivity()
    {
        return "Cycling";
    }
    public override double GetDistance()
    {
        return (_speed * GetMinutes() / 60);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return (60 / _speed);
    }
}