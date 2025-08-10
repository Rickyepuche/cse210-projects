public abstract class Goals
{
    protected string _shortName;
    protected string _description;
    protected int _points;


    //constructor
    public Goals(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    //methods
    public virtual int GetScore()
    {
        return _points;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
    public abstract string GetStringRepresentation();

}