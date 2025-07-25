public class Customer
{
    private string _name;
    private Address _address;
    private bool _inUSA = false;
    public Customer()
    {
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _inUSA = address.InTheUSA();
    }
    public void SetCustomerNameAndAddress(string name, Address address)
    {
        _name = name;
        _address = address;
        _inUSA = address.InTheUSA();
    }
    public bool GetInUSA()
    {
        return _inUSA;
    }
    public string GetName()
    {
        return _name;
    }
    public string DisplayCustomerAddress()
    {
        string address = _address.DisplayAddress();
        return address;
    }
}