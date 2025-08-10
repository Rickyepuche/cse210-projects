public class SimpleGoals : Goals
{
    private bool _isComplete = false;

    //constructor
    public SimpleGoals(string name, string description, int points) : base(name, description, points)
    {
        _description = description;
        _shortName = name;
        _points = points;
    }
    //methods
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations, you have earned {_points} points!.");
        Console.WriteLine($"You now have {_points} points");
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}