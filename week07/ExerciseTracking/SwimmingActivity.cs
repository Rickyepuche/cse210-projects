public class SwimmingActivity : Activity
{
    private int _numberOfLaps;

    public SwimmingActivity(string name, string description, float length, int numberOfLaps) : base(name, description, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float CalTotalDistance()
    {
        float distance = _numberOfLaps * 50 / 1000f;
        return distance;
    }

    public override float CalTotalSpeed()
    {
        float speed = CalTotalDistance() / _length * 60;
        return speed;
    }

    public override float CalTotalPace()
    {
        float thePace = 60 / CalTotalSpeed();
        return thePace;
    }
}