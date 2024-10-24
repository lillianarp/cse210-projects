

public class Order
{
    // attributes

    private List<Product> _products; // a list 
    private Customer _customer; // an object 

    // constructor

    public Order(Customer customer)
    {
        _customer = customer; 
        _products = new List<Product>();
    }

    // methods

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalProductPrice = CalculateTotalProductPrice();
        double shippingCost = CalculateShippingCost();
        return totalProductPrice + shippingCost;
    }

    public string GetPackagingLabel()
    {
        string label = "====== Packing Label ======\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "====== Shipping Label ======\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress(); // grabs this from the Address class
        return label;
    }

    // helper methods - we can keep these private because they're only used in this class
    private double CalculateTotalProductPrice()
    {
        double totalProductPrice = 0;
        foreach (Product product in _products)
        {
            totalProductPrice += product.GetTotalCost();
        }
        return totalProductPrice;
    }

    private double CalculateShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5.0; // USA shipping cost
        }
        else
        {
            return 35.0; // international shipping 
        }
    }

}