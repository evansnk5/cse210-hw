using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // instance of Fraction class
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(43);
        Fraction f3 = new Fraction(33, 7);
        Fraction f4 = new Fraction();

        // using the getters and setters
        f4.SetTop(13);
        f4.SetBottom(4);

        // using the GetFractionString and GetDecimalValue methods
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());



        
        
 
       



    }
}