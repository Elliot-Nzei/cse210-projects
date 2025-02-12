using System;
using System.Threading;

public class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {Name}...");
        Console.WriteLine(Description);
        Console.Write("Enter duration (in seconds): ");
        while (!int.TryParse(Console.ReadLine(), out Duration) || Duration <= 0)
        {
            Console.Write("Invalid input. Enter a valid duration: ");
        }
        Console.WriteLine("Get ready...");
        ShowCountdown(3);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }
}
