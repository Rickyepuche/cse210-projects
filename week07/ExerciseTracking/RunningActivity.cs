public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(string name, string description, float length, float distance) : base(name, description, length)
    {
        _distance = distance;
    }

    public override float CalTotalDistance()
    {
        float theDistance = _distance;
        return theDistance;
    }

    public override float CalTotalSpeed()
    {
        float speed = (CalTotalDistance() / _length) * 60;
        return speed;
    }

    public override float CalTotalPace()
    {
        float pace = _length / _distance;
        return pace;
    }

}