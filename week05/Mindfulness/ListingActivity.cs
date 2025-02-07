using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, string duration, int count, List<string> prompts )
    : base(name, description,duration)
    {
        _count = count;
        _prompts = prompts;
    }
    public void Run()
    {

    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetLstFromUser()
    {

    }

}
