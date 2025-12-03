using System;

public class ListActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "List as many things as you are grateful for.",
        "List as many personal strengths as you can.",
        "List as many achievements you are proud of.",
        "List as many people who have positively influenced your life.",
        "List as many activities that make you happy.",
        "List as many places you would like to visit.",
        "List as many times you felt the Holy Ghost",
        "List as many skills you would like to learn.",
    };
    public ListActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
    }
    
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        Console.WriteLine("Start listing items: ");
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
            _count++;
        }
        return items;
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

        Console.WriteLine($"\nRespond to the following prompt:\n--- {GetRandomPrompt()} ---");
        Console.Write("Get ready... ");
        ShowCountDown(5);

        GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
}