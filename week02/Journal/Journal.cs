
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
        using (StreamWriter writer = new StreamWriter (file))
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine($"{entry._date} {entry._promptText} {entry._entryText}");
            }
        }
        Console.WriteLine($"Journal save to {file}");



    }
    public void LoadFromFile(string file)
    {

    }

}