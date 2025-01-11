using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");


        Console.Write("What is your grade?:");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        int grad = 90;
        int gra = 80;
        int gre = 70;
        int grb = 60;
        int grabb = 60;

        if (number >= grad)
        {
            Console.WriteLine("A");
        }

        else if (number >= gra)
        {
            Console.WriteLine("B");
        }

        else if (number >= gre)
        {
            Console.WriteLine("C");
        }

        else if (number >= grb )
        {
            Console.WriteLine("D");
        }

         else if (number <= grabb )
        {
            Console.WriteLine("F");
        }

        if (number >= gre)
        {
            Console.WriteLine("Congratulations, You have pass this course ");
        }
        else
        {
            Console.WriteLine($"You did your best but your score {number}, is lower for a pass. ");
        }


        string letter;

    
        if (number >= grad)
        {
            letter = "A";
        }
        else if (number >= gra)
        {
            letter = "B";
        }
        else if (number >= gre)
        {
            letter = "C";
        }
        else if (number >= grb)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        
        Console.WriteLine($"Your letter grade is: {letter}");

        
        if (number >= gre)
        {
            Console.WriteLine("Congratulations! You have passed this course.");
        }
        else
        {
            Console.WriteLine($"You did your best, but your score {number} is too low to pass.");
        }
    }

    
}