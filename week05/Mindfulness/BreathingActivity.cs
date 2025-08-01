using System;
using System.Threading;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void BreatheTimer()
    {
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        DateTime endTime = DateTime.Now + duration;
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        while (DateTime.Now < endTime)
        {
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"\rBreathe in... {i}s");
                Thread.Sleep(1000);    
            }
            Console.WriteLine("\rBreathe in...");  

            for (int i = 6; i > 0; i--)
            {
                Console.Write($"\rBreathe out... {i}s");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\rBreathe out...");
            Console.WriteLine(); 
        }
    }
    public void Run()
    {   
        Console.Clear();
        DisplayStartingMessage();
        BreatheTimer();
        DisplayEndingMessage();
    }
}