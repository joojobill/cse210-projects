using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
         int userNumber = -1;
         while (userNumber != 0) {
            Console.WriteLine("Enter a number (0 to quit)");

            string userEnter = Console.ReadLine();
            userNumber = int.Parse(userEnter);
            if (userNumber != 0) {
                numbers.Add(userNumber);
            }
         }

         int sum = 0;
         foreach (int number in numbers) {
            sum += number;
         }

         Console.WriteLine($"YOur total sum is {sum}");

         int max = numbers[0];

         foreach(int number in numbers) {
            if (number > max) {
                max = number;
            }
         }

         Console.WriteLine($"The max is: {max}");






    }
}