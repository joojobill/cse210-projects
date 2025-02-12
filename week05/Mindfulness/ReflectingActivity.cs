using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() :base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
           "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless." 
        };
        _questions = new List<string>
        {
             "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now reflect on the following questions:");
        int remainingTime = _duration;
        while (remainingTime > 0)
        {
            Console.WriteLine(_questions[new Random().Next(_questions.Count)]);
            ShowSpinner(5); // Pause for 5 seconds with a spinner
            remainingTime -= 5;
        }

        DisplayEndingMessage();

    }
}