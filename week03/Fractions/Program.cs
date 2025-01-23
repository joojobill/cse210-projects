using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Frantion frantion1 = new Frantion();
        Console.WriteLine(frantion1.GetFractionString());
        Console.WriteLine(frantion1.GetDecimalValue());


        Frantion frantion2 = new Frantion(5);
        {
            Console.WriteLine(frantion2.GetFractionString());
            Console.WriteLine(frantion2.GetDecimalValue());
        }
        
        Frantion frantion3 = new Frantion(3,4);
        {
            Console.WriteLine(frantion3.GetFractionString());
            Console.WriteLine(frantion3.GetDecimalValue());
        }

    
        Frantion frantion4 = new Frantion(1,3);
        {
            Console.WriteLine(frantion4.GetFractionString());
            Console.WriteLine(frantion4.GetFractionString());


        }



    }
}