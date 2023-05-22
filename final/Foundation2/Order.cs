public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public double CalculateTotal()
    {
        double sum = 0;
        foreach (Product product in _products)
        {
            sum += product.GetTotalPrice();
        }

        if (_customer.USCitizen() == true)
        {
            sum += 5;
        }
        else
        {
            sum += 35;
        }

        return sum;
    }
    public string PackingLabel()
    {
        List<string> productLabel = new List<string>();
        foreach (Product product in _products)
        {
            string name = product.GetName();
            int id = product.GetID();
            string label = ($"{name} - {id}");
            productLabel.Add(label);
        }
        return (string.Join(", ", productLabel));
    }
    public string ShippingLabel()
    {
        return ($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }
}