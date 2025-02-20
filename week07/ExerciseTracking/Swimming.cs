using System;
using System.Collections.Generic;

// Swimming Class
class Swimming : Activity
{
    private int laps;
    
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }
    
    public override double GetDistance() => (laps * 50) / 1000.0; // Convert meters to km
    public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / GetDistance();
}