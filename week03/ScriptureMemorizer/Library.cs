using System.Dynamic;

public class Library
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private int _verse;
    private string _verseText;

    public Library(int masteryPassage)
    {
        string[] lines = File.ReadAllLines("passages.txt");
        string[] parts = lines[masteryPassage].Split('|');

        _verseText = parts[1].Trim();

        string[] referenceParts = parts[0].Trim().Split(' ');

        string chapterAndVerse = referenceParts[^1]; 
        _book = string.Join(" ", referenceParts[..^1]); 

        
        string[] chapterSplit = chapterAndVerse.Split(':');
        _chapter = int.Parse(chapterSplit[0]);

        if (chapterSplit[1].Contains('-'))
        {
            string[] verses = chapterSplit[1].Split('-');
            _startVerse = int.Parse(verses[0]);
            _endVerse = int.Parse(verses[1]);
        }
        else
        {
            _startVerse = int.Parse(chapterSplit[1]);
            _endVerse = 0;
        }

        _verse = _startVerse;
    }

    public string GetVerseText()
    {
        return _verseText;
    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetStartVerse()
    {
        return _startVerse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public int GetVerse()
    {
        return _verse;
    }
}