// Ran out of time, couldn't add enhancements TwT

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Activities!");
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            Activity activity = null;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    break;
                case "3":
                    activity = new ListActivity();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please choose a valid option.");
                    continue;
            }
            if (activity != null)
            {
                activity.Run();
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            Console.Clear();
        }
    }
}