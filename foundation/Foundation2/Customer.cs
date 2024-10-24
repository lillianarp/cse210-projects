
public class Customer
{
    // attributes

    private string _name;
    private Address _address;

    // constructor

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // methods

    public string GetName()
    {
        return _name; 
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA(); // calling this from the Address class 
    }

    public Address GetAddress()
    {
        return _address; 
    }
}