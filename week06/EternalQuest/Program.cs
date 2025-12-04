using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        // Additional game initialization code would go here
        
        while (true)
        {
            Console.WriteLine("Main Menu:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            // Code to handle user input and interact with goals would go here
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();
            if (choice == "6")
            {
                Console.WriteLine("Thank you for playing Eternal Quest!");
                break;
            }
            else
            {
                Console.WriteLine("Feature not implemented yet.");
                // for testing purposes
                SimpleGoal testGoal = new SimpleGoal("Test Goal", "This is a test goal.", 100);
                Console.WriteLine(testGoal.GetDetailsString());
            }
        }
    }
}