using System;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine($"How Long in seconds would you like for your session?");
        string input = Console.ReadLine();
        // check for valid input
        if (double.TryParse(input, out double durationValue))
        {
            _duration = (int)Math.Round(durationValue);
        }
        else
        {
            _duration = 120; 
        }
        Console.Clear();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done");
        ShowSpinner(4);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        ShowSpinner(3);// Wait for 3 seconds before ending
    }
    public void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int counter = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write($"{spinner[counter % spinner.Length]}");
            counter++;
            Thread.Sleep(300); // Spinner speed
            Console.Write("\b \b");
        } 
        Console.WriteLine(); // Move to the next line after spinner 
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write($"{i}s\r");
            Thread.Sleep(1000);
            
        }

    }
}