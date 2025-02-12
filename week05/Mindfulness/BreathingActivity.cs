using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Exercise", "Focus on your breathing to relax.")
    {
    }

    public void Perform()
    {
        StartActivity();
        int cycles = Duration / 6;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Hold...");
            ShowCountdown(2);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }

        Console.WriteLine("\nGood job! You've completed the breathing exercise.");
    }
}
