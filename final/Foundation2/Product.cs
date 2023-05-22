public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetID()
    {
        return _productId;
    }
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}