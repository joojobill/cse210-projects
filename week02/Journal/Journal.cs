
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
        if (!File.Exists(file))
        {
            Console.WriteLine("file not found");
            return;
        }
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string [] parts = line.Split("|");
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[3]);
                _entries.Add(entry);
                
                
            }
        }
        Console.WriteLine($"Journal load from {file}");

    }


}