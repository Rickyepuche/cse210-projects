public class Reference
{
    //Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    //Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public string GetBook()
    {
        return _book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public void SetStartVerse(int startVerse)
    {
        _verse = startVerse;
    }
    public int GetStartVerse()
    {
        return _verse;
    }
    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
    public int GetEndVerse()
    {
        
        return _endVerse;
    }
    public string GetDisplayText()
    {
        string endVerseText;
        string hypen = "";
        if (_endVerse < 1)
        {
            endVerseText = _endVerse.ToString();
            endVerseText = "";
            hypen = "";
        }
        else
        {
            endVerseText = GetEndVerse().ToString();
            hypen = "-";
        }
        string text = $"{GetBook()} {GetChapter()}:{GetStartVerse()}{hypen}{endVerseText}";
        return text;
    }
}