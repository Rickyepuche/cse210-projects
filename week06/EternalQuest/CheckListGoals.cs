public class CheckListGoals : Goals
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    //constructor
    public CheckListGoals(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }
    //method
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;
        if (IsComplete())
        {
            _points = _points + _bonus;
            Console.WriteLine($"Congratulations, you have earned {_points} points!");
            Console.WriteLine($"You now have {_points} points");
        }
        else
        {
            Console.WriteLine($"Congratulations, you have earned {_points} points!");
            Console.WriteLine($"You now have {_points} points");
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}