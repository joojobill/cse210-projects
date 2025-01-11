using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string UserName = PromptUserName();
        Console.WriteLine($"Hello {UserName}");

        int UserNumber = PromptUserNumber();
        Console.WriteLine($"Your number is {UserNumber}");

        Console.WriteLine("write a number to square");
        int number = int.Parse(Console.ReadLine());

        int squaredNumber = SquareNumber(number);
        Console.WriteLine($"The square of {number} is {squaredNumber}");

        DisplayResult(UserName, squaredNumber);



    }

    static void DisplayWelcome()
     {
        Console.WriteLine("Welcome to this Progrm");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        return name;

    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your number");
        int numbers = int.Parse(Console.ReadLine());
        return numbers;
    }

    static int SquareNumber(int Number)
    {
        int nub =  Number;
        return nub * nub;
    }

    static void DisplayResult(string name, int nub)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {nub}");
    }
}