using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_name} Activity with a duration of {_duration} seconds.");
    }
    
    public void ShowSpinner(int seconds = 0)
    {
        if (seconds == 0)
        {
            // infinite spinner
            while (!Console.KeyAvailable)
            {
                Console.Write("|");
                System.Threading.Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("/");
                System.Threading.Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("—");
                System.Threading.Thread.Sleep(250);
                Console.Write("\b \b");
                Console.Write("\\");
                System.Threading.Thread.Sleep(250);
                Console.Write("\b \b");
            }
            Console.ReadKey(); // Clear the key press
            return;
        }
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("—");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    public virtual void Run()
    {
        // This method will be overridden in derived classes
    }
}
