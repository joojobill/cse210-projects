using System;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._compang = "MTN Ghana";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Console.WriteLine("Company: " + job1._compang);

    }


    
}