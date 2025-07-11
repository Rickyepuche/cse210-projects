public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    //Add the behaiviors
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"Date: {e._date} - Prompt: {e._promptText}");
                outputFile.WriteLine(e._entryText);
                outputFile.WriteLine();
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string [] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}