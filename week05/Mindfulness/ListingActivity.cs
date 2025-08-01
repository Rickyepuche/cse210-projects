using System;
using System.Threading;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity( string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
    }

    public void InitializePrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("How have you shown a someone Love today?");
    }
    
    public string GetRandomPrompt()
    {
        int index = 0;
        Random rnd = new Random();
        index = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        DateTime endTime = DateTime.Now + duration;
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"\"{GetRandomPrompt()}\"");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(_count);
    
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            responses.Add(input);
            Thread.Sleep(200);
        }
        Console.WriteLine($"You have listed {responses.Count} items.");
        return responses;
    }
    public void Run()
    {
        Console.Clear();
        InitializePrompts();
        GetRandomPrompt();
        DisplayStartingMessage();
        GetListFromUser();
        DisplayEndingMessage();
    }
}