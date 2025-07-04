using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName(); 
        int number = PromptUserNumber();
        int result = SquareNumber(number);
        DisplayResult(name, result);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string text = Console.ReadLine();
        int userNumber = int.Parse(text);
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        int squaredTotal = number * number;
        return squaredTotal;
    }
    static void DisplayResult(string name, int number) 
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}