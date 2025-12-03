using System;

public class ReflectingActivity : Activity
{
    private List<string> questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _prompts = new List<string>()
    {
        "Think about a time when you overcame a challenge.",
        "Recall a moment when you helped someone in need.",
        "Reflect on a time when you achieved a personal goal.",
        "Remember an experience that made you feel proud.",
        "Think about a situation where you showed kindness."
    };

    public ReflectingActivity() 
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
    
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(questions.Count);
        string question = questions[index];
        questions.RemoveAt(index); // Eliminates duplicates
        return question;
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

        Console.WriteLine($"\nConsider the following prompt:\n--- {GetRandomPrompt()} ---");
        Console.Write("\nWhen you have something in mind, press any key to continue.");
        ShowSpinner();
        
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n{GetRandomQuestion()}");
            ShowSpinner(10);
        }

        DisplayEndingMessage();
    }
}