using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("what is the  magic number?");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(magicNumber);

        Console.Write("what is your guess?");
        int guessNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(guessNumber);


        if (magicNumber > guessNumber) {
            Console.Write("Higher");
        }
        else if (magicNumber < guessNumber) {
            Console.Write(" Lower ");
        }
        else {
            Console.WriteLine("You guessed it ");
        }

        

        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine("now guess the random number");

        guessNumber = -1;

        while (guessNumber != magicNumber) {
            Console.Write("What is the magic number?");
            guessNumber = int.Parse(Console.ReadLine());

        if (guessNumber > magicNumber){
            Console.WriteLine("lower");
        }
        else if (guessNumber < magicNumber) {
            Console.WriteLine("Higher");
        }
        else {
            Console.WriteLine("You Guessed it ");
        }

        }



    }
}