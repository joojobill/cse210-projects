using System;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
        Console.WriteLine("You have a few seconds to think about it...");
        ShowCountDown(5); // Countdown for 5 seconds

        Console.WriteLine("Start listing items:");
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }
}