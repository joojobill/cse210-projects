public class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string prompt, string entry)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
    }
    

    public void Display()
    {
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

 
}