using System;
using System.ComponentModel;


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


        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._compang = "Google";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Isaac Hooper";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        

    }


    
}