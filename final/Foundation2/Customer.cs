public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.FullAddress();
    } 
    public bool USCitizen()
    {
        if (_address.InUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}