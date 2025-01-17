public class PromptGenerator 
{
    public List<string> _prompts; 
    private Random _random;

    public PromptGenerator()
    {
         _prompts = new List<string>
        {
            "We forget",
            "It's not convenient to get out our written journal or find the electronic document",
            "We don't feel like we have anything interesting to say",
            "We don't feel like we have time for it",
            "We aren't sure what to write",
            "We feel overwhelmed with writing every event of the day, so we just don't write anything."
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
       

    }

}