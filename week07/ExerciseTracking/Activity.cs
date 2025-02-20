using System;
using System.Collections.Generic;

// Base class Activity
abstract class Activity
{
    private string date;
    private int minutes;
    
    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }
    
    public int GetMinutes() => minutes;
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public virtual string GetSummary()
    {
        return $"{date} {this.GetType().Name} ({minutes} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}