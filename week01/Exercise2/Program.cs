using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade : ");
        String result = Console.ReadLine();
        int grade = int.Parse(result);
        


        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        // PASS IS 70
        if (grade >= 70)
        {
            Console.WriteLine("Congrats");
        }
        else
        {
            Console.WriteLine("Better luck next time!");

        }

    }
}