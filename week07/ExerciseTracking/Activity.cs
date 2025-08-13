using System;
using System.Threading;
public abstract class Activity
{
    //Attributes
    protected string _name;
    protected string _description;
    protected float _length;

    //Constuctor
    public Activity(string name, string description, float length)
    {
        _name = name;
        _description = description;
        _length = length;
    }

    public abstract float CalTotalDistance();

    public abstract float CalTotalSpeed();

    public abstract float CalTotalPace();

    public string GetSummary()
    {
        // Get the current date using datetime

        DateTime now = DateTime.Now;
        string date = now.ToString("dd MMMM yyyy");

        string displayText = $"{date} {_name} ({_length} min)- Distance {CalTotalDistance():F2} km, Speed {CalTotalSpeed():F2} kph, Pace: {CalTotalPace():F2} min per km";
        return displayText;
    }
    
}