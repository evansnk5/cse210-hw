using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Test Assignment instance
        Assignment testAssignment = new Assignment("Evans Nkrumah", "Math Test");
        // Display the summary of the test assignment
        Console.WriteLine($"Test Assignment Summary:" +
                          $"\n{testAssignment.GetSummary()}");

        // Create a Math Assignment instance
        MathAssignment mathAssignment = new MathAssignment("Thomas Smith", "Algebra", "Section 7.2  ", "Problems 1-10");
        Console.WriteLine($"\nMath Assignment Summary:" +
                          $"\n{mathAssignment.GetSummary()}" +
                          $"\n{mathAssignment.GetHomework()}");

        // Create a Writing Assignment instance
        WritingAssignment writingAssignment = new WritingAssignment("Mary Johnson", "Shakespeare", "Romeo and Juliet");
        Console.WriteLine($"\nWriting Assignment Summary:" +
                          $"\n{writingAssignment.GetWrtingInformation()}");



    }
}