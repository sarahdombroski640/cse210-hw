using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> productList1 = new List<Product>();
        Product p1 = new Product("Oreos", 1421, 3.29, 1);
        Product p2 = new Product("Plates", 224, 1.59, 3);
        Product p3 = new Product("Super Mario Movie", 34422, 5.99, 1);

        productList1.Add(p1);
        productList1.Add(p2);
        productList1.Add(p3);

        Address a1 = new Address("1425 Joey Ave", "Rexburg", "Idaho", "United States");
        Customer c1 = new Customer("Billy Bob", a1);
        Order o1 = new Order(productList1, c1);

        Console.Clear();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(o1.PackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: {o1.CalculateTotal()}");


        List<Product> productList2 = new List<Product>();
        Product p4 = new Product("Mac and Cheese", 1522, 3.29, 3);
        Product p5 = new Product("Rocking Chair", 5342, 59.34, 1);
        Product p6 = new Product("Super Mario Movie", 34422, 5.99, 1);
        Product p7 = new Product("Hydro Flask 32 Oz.", 3342, 25.99, 1);

        productList2.Add(p4);
        productList2.Add(p5);
        productList2.Add(p6);
        productList2.Add(p7);

        Address a2 = new Address("24 Rue Des Fleurs", "Paris", "Ile-de-France", "France");
        Customer c2 = new Customer("Suzie Joe", a2);
        Order o2 = new Order(productList2, c2);

        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(o2.PackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: {o2.CalculateTotal()}");
    }
}