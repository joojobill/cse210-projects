using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() :base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing")
    {   

    }

    public void Run()
    {
        DisplayStartingMessage();
        int remainingTime = _duration;

        while (remainingTime > 0)
        {
            Console.WriteLine("Breath in....");
            ShowCountDown(4); // countdown for 4 seconds
            if (remainingTime <= 0) break;
            Console.WriteLine("Breath out...");
            ShowCountDown(6);
            remainingTime -= 6;  

        }

        DisplayEndingMessage();

        
    }

}