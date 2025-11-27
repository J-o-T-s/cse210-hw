using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("John Doe", "Algebra", "Section 5.2", "1-10 odd");
        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "History Essay", "The Causes of World War II");

        Console.WriteLine("Math Assignment Details:");
        Console.WriteLine(mathAssignment.GetHomeworkDetails());
        Console.WriteLine();

        Console.WriteLine("Writing Assignment Details:");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}