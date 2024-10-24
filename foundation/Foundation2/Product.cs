
public class Product
{

    // attributes

    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // constructor

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // methods

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public double GetTotalCost()
    {
        return _price * _quantity; 
    }

    public int GetQuantity()
    {
        return _quantity; 
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

}