using System;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void InitializePromptsAndQuestions()
    {
        // Initialize prompts and questions
        _prompts.Add("Think of a time when you felt truly at peace.");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you felt a strong connection with nature.");
        _prompts.Add("Think of a time when you overcame a significant challenge.");
        _prompts.Add("Think of a time when you learned something new about yourself.");
        _prompts.Add("Think of a time when you felt a deep sense of gratitude.");

        _questions.Add("What did you learn from that experience?");
        _questions.Add("How did that experience change you?");
        _questions.Add("What was the most challenging part of that experience?");
        _questions.Add("How did you feel during that experience?");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public string GetRandomPrompt()
    {
        int index = 0;
        Random rnd = new Random();
        index = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        int index = 0;
        Random rnd = new Random();
        index = rnd.Next(_questions.Count);
        string randomQuestion = _questions[index];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        DateTime endTime = DateTime.Now + duration;
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        string input = Console.ReadLine();
        if (input == "")
        {
            return;
        }   
        else
        {
            Console.WriteLine("Press Enter");
            input = Console.ReadLine();
        }
        
        return;
    }   
    public void DisplayQuestions()
    {
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        DateTime endTime = DateTime.Now + duration;
        Console.WriteLine();
        Console.WriteLine("Now Ponder on each of the following questions as they relate to this experience ");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.Write($"{GetRandomQuestion()} ");
            ShowSpinner(10);
            Thread.Sleep(100);

        }
    }
    public void Run()
    {
        Console.Clear();
        InitializePromptsAndQuestions();
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
}