using System;

class Program
{
    static void Main(string[] args)
    {
        //1st order
        Order q01 = new Order();
        Customer first = new Customer();
        Address firstAddress = new Address("1, wisconsin off Dog Road", "Benin City", "Edo State", "Nigeria");
        first.SetCustomerNameAndAddress("Richard Wayne", firstAddress);
        Product productq1 = new Product("Banana", "132d", 2, 5);
        Product productq2 = new Product("Meat", "152d", 10, 3);
        Product productq3 = new Product("Orange", "332a", 5, 5);
        Product productq4 = new Product("Rice", "172c", 20, 2);
        //create order
        q01.SetCustomerOnOrder(first);
        q01.SetProduct(productq1);
        q01.SetProduct(productq2);
        q01.SetProduct(productq3);
        q01.SetProduct(productq4);
        //display
        Console.WriteLine(q01.DisplayPackingLabel());
        Console.WriteLine(q01.CalculateTotalCost(first));
        Console.WriteLine(q01.DisplayShippingLabel());
        
        //2nd order
        Order k02 = new Order();
        Customer second = new Customer();
        Address secondAddress = new Address("2, Naomi Road", "salt lake city", "Utah", "USA");
        second.SetCustomerNameAndAddress("Catherine Edigin", secondAddress);
        Product productk1 = new Product("Banana", "132d", 2, 5);
        Product productk2 = new Product("Meat", "152d", 10, 3);
        Product productk3 = new Product("Orange", "332a", 5, 5);
        Product productk4 = new Product("Rice", "172c", 20, 2);
        //create order
        k02.SetCustomerOnOrder(second);
        k02.SetProduct(productk1);
        k02.SetProduct(productk2);
        k02.SetProduct(productk3);
        k02.SetProduct(productk4);
        //display
        Console.WriteLine(k02.DisplayPackingLabel());
        Console.WriteLine(k02.CalculateTotalCost(second));
        Console.WriteLine(k02.DisplayShippingLabel());

        //3rd order
        Order s03 = new Order();
        Customer third = new Customer();
        Address thirdAddress = new Address("2, Naomi Road", "salt lake city", "Utah", "USA");
        third.SetCustomerNameAndAddress("Catherine Edigin", thirdAddress);
        Product products1 = new Product("Fish", "132d", 2, 5);
        Product products2 = new Product("Beans", "152d", 10, 3);
        Product products3 = new Product("cherry", "332a", 5, 5);
        Product products4 = new Product("rice", "172c", 20, 2);
        //create order
        s03.SetCustomerOnOrder(third);
        s03.SetProduct(products1);
        s03.SetProduct(products2);
        s03.SetProduct(products3);
        s03.SetProduct(products4);
        //display
        Console.WriteLine(s03.DisplayPackingLabel());
        Console.WriteLine(s03.CalculateTotalCost(third));
        Console.WriteLine(s03.DisplayShippingLabel());
    }
}