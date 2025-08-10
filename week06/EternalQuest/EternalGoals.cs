public class EternalGoals : Goals
{
    //constructor
    public EternalGoals(string name, string description, int points) : base(name, description, points)
    {
        _description = description;
        _shortName = name;
        _points = points;
    }
    //methods
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {_points} points!");
        Console.WriteLine($"You now have {_points} points");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName}|{_description}|{_points}";
    }
}
