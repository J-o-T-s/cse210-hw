using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    private void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    
    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
    private void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    private void CalculateTotalPoints()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i].IsComplete())
            {
                _score += _goals[i].GetPoints();
            }
        }
    }
    private void DisplayPlayerInfo()
    {
        CalculateTotalPoints();
        Console.WriteLine($"Score: {_score}");
    }
    private void RecordEvent()
    {
        while (true)
        {
            Console.WriteLine("\nSelect the goal you accomplished:");
            ListGoalNames();
            int choice = int.Parse(Console.ReadLine());
            if (choice >= 1 && choice <= _goals.Count)
            {
                _goals[choice - 1].RecordEvent();
                break;
            }
            Console.WriteLine("Invalid choice. Please select a valid goal number:");
        }
    }
    
    private void SaveGoals()
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    
    private void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string goalType = parts[0];
                    if (goalType == "SimpleGoal")
                    {
                        string shortName = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        SimpleGoal goal = new SimpleGoal(shortName, description, points);
                        _goals.Add(goal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        string shortName = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        EternalGoal goal = new EternalGoal(shortName, description, points);
                        _goals.Add(goal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        string shortName = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        ChecklistGoal goal = new ChecklistGoal(shortName, description, points, target, bonus);
                        // Manually set the amount completed
                        goal.SetAmountCompleted(amountCompleted);
                        _goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine($"Unknown goal type: {goalType}"); // silly, but okay :D
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    
    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        // Additional game initialization code would go here
        
        while (true)
        {
            DisplayPlayerInfo();
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
                switch (choice)
                {
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("Choose goal type:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                            string goalType = Console.ReadLine();
                            Console.Write("Enter short name: ");
                            string shortName = Console.ReadLine();
                            Console.Write("Enter description: ");
                            string description = Console.ReadLine();
                            Console.Write("Enter points: ");
                            int points = int.Parse(Console.ReadLine());
                            if (goalType == "1")
                            {
                                CreateGoal(new SimpleGoal(shortName, description, points));
                                break;
                            }
                            else if (goalType == "2")
                            {
                                CreateGoal(new EternalGoal(shortName, description, points));
                                break;
                            }
                            else if (goalType == "3")
                            {
                                Console.Write("Enter target number of completions: ");
                                int target = int.Parse(Console.ReadLine());
                                Console.Write("Enter bonus points: ");
                                int bonus = int.Parse(Console.ReadLine());
                                CreateGoal(new ChecklistGoal(shortName, description, points, target, bonus));
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid goal type selected.");
                                continue;
                            }
                        }
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
