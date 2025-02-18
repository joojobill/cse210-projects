using System;
using System.Security.Cryptography;

public class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return (GetDistance() / _lengthInMinutes) * 60;
    }
    public virtual double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_lengthInMinutes}min) - Distance: {GetDistance():F1} miles,Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}