using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        f.SetTop(1);
        f.SetBottom(3);
        string fraction1 = f.GetFractionString();
        Console.WriteLine(fraction1);
        double result = f.GetDecimalValue();
        Console.WriteLine(result);
    }
}