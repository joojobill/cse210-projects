using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private] List<string> _questions;

    public ReflectingActivity(string name, string description, string duration, List<string> prompts, List<string> questions)
    : base(name,description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
    public void Run  
}