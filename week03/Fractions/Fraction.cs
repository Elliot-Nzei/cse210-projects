using System;

public class Fraction
{
    // Private attributes for numerator (top) and denominator (bottom)
    private int _top;
    private int _bottom;

    // Constructor that initializes the fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that initializes the fraction with a numerator, default denominator is 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor that initializes the fraction with both numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the numerator (top)
    public int GetTop()
    {
        return _top;
    }

    // Setter for the numerator (top)
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the denominator (bottom)
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the denominator (bottom)
    public void SetBottom(int bottom)
    {
        if (bottom != 0) // Ensure the denominator isn't zero
        {
            _bottom = bottom;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero.");
        }
    }

    // Method to return the fraction as a string in the form "numerator/denominator"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}