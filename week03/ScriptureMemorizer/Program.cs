// Author: Kuma Dev

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine("-------------------");

        // Difficulty selection
        string level;
        do
        {
            Console.Write("Choose difficulty (easy / normal / hard): ");
            level = Console.ReadLine()?.Trim().ToLower() ?? "";
        } while (level != "easy" && level != "normal" && level != "hard");

        GameSettings settings = new GameSettings(level);

        // Scripture selection (random)
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandom();

        Statistics stats = new Statistics();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("[ENTER] Hide more  |  'hint' for help  |  'quit' to stop");
            Console.Write("> ");

            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit") break;

            if (input == "hint")
            {
                Console.WriteLine(scripture.GetHint());
                Console.WriteLine("Press ENTER...");
                Console.ReadLine();
                continue;
            }

            scripture.HideRandomWords(settings.HideCount);
            stats.Increment();

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words hidden");
                Console.WriteLine(stats.GetSummary());
                break;
            }
        }
    }
}
