class Program
{
    static void Main(string[] args)
    {
        // Create a few instances of fractions using different constructors
        Fraction fraction1 = new Fraction(); // Default: 1/1
        Fraction fraction2 = new Fraction(6); // Initialized to 6/1
        Fraction fraction3 = new Fraction(3, 4); // Initialized to 3/4

        // Display the fractions and their decimal values
        Console.WriteLine(fraction1.GetFractionString()); // 1/1
        Console.WriteLine(fraction1.GetDecimalValue());  // 1

        Console.WriteLine(fraction2.GetFractionString()); // 6/1
        Console.WriteLine(fraction2.GetDecimalValue());  // 6

        Console.WriteLine(fraction3.GetFractionString()); // 3/4
        Console.WriteLine(fraction3.GetDecimalValue());  // 0.75

        // Test modifying fraction values using setters
        fraction3.SetTop(5);
        fraction3.SetBottom(2);
        Console.WriteLine(fraction3.GetFractionString()); // 5/2
        Console.WriteLine(fraction3.GetDecimalValue());  // 2.5
    }
}
