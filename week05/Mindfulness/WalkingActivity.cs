public class WalkingActivity : Activity
{
    public WalkingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayWalkPrompts()
    {
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        DateTime endTime = DateTime.Now + duration;
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        int actTime = _duration / 5;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Take a short walk and observe: ");
            Console.WriteLine();
            Console.WriteLine("What are 5 things you can see?...");
            ShowSpinner(actTime);
            Console.WriteLine("What are 4 things you can feel?...");
            ShowSpinner(actTime);
            Console.WriteLine("What are 3 things you can hear?...");
            ShowSpinner(actTime);
            Console.WriteLine("What are 2 things you can smell?...");
            ShowSpinner(actTime);
            Console.WriteLine("What is 1 thing you can taste?...");
            ShowSpinner(actTime);
            Thread.Sleep(100);
        }
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        DisplayWalkPrompts();
        DisplayEndingMessage();
    }
}