using System;


abstract class Activity
{
    private DateTime _date;
    private double _lengthMinutes;

    public Activity(DateTime date, double lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public double LengthMinutes
    {
        get { return _lengthMinutes; }
    }

    // Abstract methods for polymorphism
    public abstract double GetDistance(); // in miles
    public abstract double GetSpeed();    // mph
    public abstract double GetPace();     // min per mile

    // Shared summary method
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}
