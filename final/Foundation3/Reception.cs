public class Reception : Event
{
    private string _email;
    public Reception(string email, string title, string description, string date, string time, Address address) :base(title, description, date, time, address)
    {
        _email = email;
    }
    public string GetStandardDetails()
    {
        return ($"{GetTitle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress()}");
    }
    public string GetFullDetails()
    {
        return ($"{GetTitle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress()}\nReception- This event is a wedding reception. Please RSVP to {_email}.");
    }
    public string GetShortDescription()
    {
        return ($"Reception - {GetTitle()}\n{GetDate()}");
    }
}