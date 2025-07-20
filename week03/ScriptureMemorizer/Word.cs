public class Word
{
    private string _text;
    private bool _isHidden;
    //constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
   
    public void Show()
    {
        _isHidden = false;
    }
   
    public bool IsHidden()
    {
        bool hide = _isHidden;
        return hide;
    }
   
    public string GetDisplayText()
    {
        if(_isHidden == true)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
    
}