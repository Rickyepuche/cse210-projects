public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        double result = (double)_top / _bottom;
        return result;
    }
}