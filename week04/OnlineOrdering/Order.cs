using System.Reflection.Emit;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    
    public void SetCustomerOnOrder(Customer customer)
    {
        _customer = customer;
    }
    public void SetProduct(Product product)
    {
        _products.Add(product);
    }
    //methods
    public string CalculateTotalCost(Customer customer)
    {
        int total = 0;
        int sum = 0;
        foreach (Product p in _products)
        {
            sum += p.GetProductCost();
        }
        if (customer.GetInUSA())
        {
            total = sum + 5;
        }
        else if (!customer.GetInUSA())
        {
            total = sum + 35;
        }
        return $"Total Price:${total}";
    }
    public string DisplayPackingLabel()
    {
        string label = "Product Label:\n";
        foreach (Product p in _products)
        {
            label += $"Product Name: {p.GetProductName()} Product ID: {p.GetProductID()}\n";
        }
        return label;
    }
    public string DisplayShippingLabel()
    {
        return $"Shipping Label:\nCustomer Name: {_customer.GetName()}\nAddress: {_customer.DisplayCustomerAddress()}\n";
    }
}