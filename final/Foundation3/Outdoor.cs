public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string weather, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }
    public string GetStandardDetails()
    {
        return ($"{GetTitle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress()}");
    }
    public string GetFullDetails()
    {
        return ($"{GetTitle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress()}\nOutdoor Event- This event is held outdoors. The weather will be {_weather}. Please dress accordingly.");
    }
    public string GetShortDescription()
    {
        return ($"Outdoor Event - {GetTitle()}\n{GetDate()}");
    }
}