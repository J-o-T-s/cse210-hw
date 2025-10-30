// A simple program that asks the user for their score and gives them a grade
// based on the score.

// Author: Josh Tuks
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        int score = int.Parse(Console.ReadLine());
        string letter;
        string sign;

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80 && score < 90)
        {
            letter = "B";
        }
        else if (score >= 70 && score < 80)
        {
            letter = "C";
        }
        else if (score >= 60 && score < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (score % 10 >= 7 && score >= 60)
        {
            sign = "+";
        }
        else if (score % 10 <= 3 && score >= 60)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");
        if (score >= 70)
        {
            Console.WriteLine("Congratulations, You have passed your test!");
        }
        else
        {
            Console.WriteLine("Sorry, You failed your test. Keep trying and I wish you better luck next time!");
        }
    }
}