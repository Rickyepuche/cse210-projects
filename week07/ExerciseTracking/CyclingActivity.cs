public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(string name, string description, float length, float speed) : base(name, description, length)
    {
        _speed = speed;
    }

    public override float CalTotalDistance()
    {
        float distance = _speed * _length / 60f;
        return distance;
    }

    public override float CalTotalSpeed()
    {
        return _speed;
    }

    public override float CalTotalPace()
    {
        float pace = 60f / _speed;
        return pace;
    }
}