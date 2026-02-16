using System;

public abstract class Activity
{
    // Shared attributes
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Encapsulation: We provide a protected getter so children can use _minutes
    // but the outside world cannot change it.
    protected int GetMinutes()
    {
        return _minutes;
    }

    // Virtual/Abstract methods to be overridden by children
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // The Summary method is defined HERE, but it calls the abstract methods above.
    // This is the power of polymorphism.
    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min) - Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}