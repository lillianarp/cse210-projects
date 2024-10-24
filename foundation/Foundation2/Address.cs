

public class Address
{

    // attributes

    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // constructor

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // methods

    public bool IsInUSA() 
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }

    public string GetFullAddress() 
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}