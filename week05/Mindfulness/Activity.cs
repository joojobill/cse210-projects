using System;

public class Activity 
{
    private string  _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the the activity in second:");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Please prepare to begin");
        ShowSpinner(3); //pause for three seconds
    }

            // Display the ending message to the user
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the activity ");
        Console.WriteLine($"You have spent {_duration} seconds on the {_name} Activity");
        ShowSpinner(3); //pause for three seconds 

    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
        Thread.Sleep(256);
        Console.Write("\b-");
        Thread.Sleep(250);
        Console.Write("\b\\");
        Thread.Sleep(250);
        Console.Write("\b|");
        Thread.Sleep(250);
        Console.Write("\b");
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        
    }
}