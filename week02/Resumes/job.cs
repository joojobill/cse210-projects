using System;

public class Job
{
    public string _jobTitle;
    public string _compang;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($" ({_compang}) {_jobTitle} {_startYear} - {_endYear}");

    }
}