using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Press any key when you are ready...");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        int cycles = GetDuration() / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("\nBreathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }
}
