using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        Journal userJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What do you want to do? ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out userChoice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); // learnt this line
                userChoice = 0; // from chatGPT :)
            }

            if (userChoice == 1)
            {
                userJournal.AskQuestionAndSaveAnswer();
            }
            else if (userChoice == 2)
            {
                userJournal.DisplayAnswerWithPromptAndDate();
            }
            else if (userChoice == 3)
            {
                userJournal.AskForFileNameAndLoadFile();
            }
            else if (userChoice == 4)
            {
                userJournal.AskForFileNameAndSaveToFile();
            }
        } while (userChoice != 5);
    }
}