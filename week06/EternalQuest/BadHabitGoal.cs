using System;

public class BadHabitGoal : Goals
{
    private int _allowedStrikes;
    private int _currentStrikes;
    private bool _isComplete;

    public BadHabitGoal(string name, string description, int allowedStrikes, int points) : base(name, description, points)
    {
        _allowedStrikes = allowedStrikes;
        _currentStrikes = 0;
        _isComplete = true;
        _points = points;
    }

    public void SetCurrentStrikes(int strikes)
    {
        _currentStrikes = strikes;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _currentStrikes++;
        ;
        if (_currentStrikes < _allowedStrikes)
        {
            Console.WriteLine($"Strike {_currentStrikes}/{_allowedStrikes}. {_points} points deducted for doing habit. Keep going, you can break it!");
        }

        CheckCompletion();

        if (!_isComplete)
        {
            Console.WriteLine($"You've reached the limit of {_allowedStrikes} strikes. Don't be discouraged—try again, you can improve next time!");
        }
    }

    public void CheckCompletion()
    {
        if (_currentStrikes >= _allowedStrikes)
        {
            _isComplete = false;
        }
    }

    public void Reset()
    {
        _currentStrikes = 0;
        _isComplete = true;
    }

    public override int GetScore()
    {
        
        return -_points;
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (!_isComplete)
        {
            return $"[FAILED] {_shortName} ({_description}) - {_currentStrikes} / {_allowedStrikes} strikes used - Lost {_points} points";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) - {_currentStrikes} / {_allowedStrikes} strikes used";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"BadHabitGoal:{_shortName}|{_description}|{_allowedStrikes}|{_points}|{_currentStrikes}|{_isComplete}";
    }
}
