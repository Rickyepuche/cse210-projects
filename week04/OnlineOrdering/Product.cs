public class Product
{
    private string _name;
    private string _productID;
    private int _price;
    private int _quantity;

    public Product()
    {
    }
    public Product(string name, string id, int price, int quantity)
    {
        _name = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }
    //Getters and setters
    public void SetProductName(string name)
    {
        _name = name;
    }
    public string GetProductName()
    {
        return _name;
    }
    public void SetProductID(string id)
    {
        _productID = id;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    //methods
    public int GetProductCost()
    {
        int cost = _price * _quantity;
        return cost;
    }
    
}