public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country.ToUpper();
    }
    //methods
    public void SetAddress(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country.ToUpper();
    }
    public bool InTheUSA()
    {
        if (_country == "USA" || _country == "UNITED STATES OF AMERICA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string DisplayAddress()
    {
        return $"Address:{_streetAddress}\n{_city}, {_state}, {_country}";
    }
}