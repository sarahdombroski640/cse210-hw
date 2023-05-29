public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetStandardDetails()
    {
        return ($"{GetTitle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress()}");
    }
    public string GetFullDetails()
    {
        return ($"{GetTitle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress()}\nLecture- This event is a lecture given by {_speaker}. It can hold up to {_capacity} people.");
    }
    public string GetShortDescription()
    {
        return ($"Lecture - {GetTitle()}\n{GetDate()}");
    }
}