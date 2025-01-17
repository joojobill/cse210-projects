
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);  
       

    }

    

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No Journal entries found.");
            return;
        }
        Console.WriteLine("Your Journal Entries;");
        Console.WriteLine("-----------------------");
        foreach(var entry in _entries)
        {
            entry.Display();
        }

    }
    

    public void SaveToFile(string file)
    {
        

    }
    public void LoadFromFile(string file)
    {

    }

}