using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 12;
        int y = 12; 

        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else if (x == y)
        {
            Console.WriteLine("Equal");
        }
        else 
        {
            Console.WriteLine("Equl");
        }
    }
}