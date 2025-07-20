using System.Globalization;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    //constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string i in words)
        {
            Word f = new Word(i);
            _words.Add(f);
        }
    }
    //methods
    public int GetLength()
    {
        int length = _words.Count;
        return length;
    }
    public void HideRandomWords(int numberToHide)
    {
        int count = 0;
        Random rnd = new Random();
        int index = rnd.Next(GetLength());
        while (count < numberToHide)
        {
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
            if (_words[index].IsHidden())
            {
                index = rnd.Next(GetLength());
                _words[index].Hide();
            }
            count++;
        }
    }
    public string GetDisplayText()
    {
        StringBuilder words = new StringBuilder();
        {
            foreach(Word i in _words)
            {
                {
                    words.Append(i.GetDisplayText());
                    words.Append(" ");
                }
            }
        }

        string displayText = $"{_reference.GetDisplayText()} '{words}' ";
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}