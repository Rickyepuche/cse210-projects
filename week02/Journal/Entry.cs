public class Entry
{
    //Class attributes
    public string _date;
    public string _promptText;
    public string _entryText;
    //class behaivours
    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        //PromptGenerator aRandomPrompt = new PromptGenerator();
        //_promptText = aRandomPrompt.GetRandomPrompt();

        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}