using System;

public class Journal
{

    public List<String> _userAnswerList = new List<String>();
    public PromptGenerator _newPromptGenerator = new PromptGenerator();
    public DateLoader _newDateLoader = new DateLoader();
    public void AskQuestionAndSaveAnswer()
    {
        string prompt;
        string userAnswer;
        string dateText;

        prompt = _newPromptGenerator.GeneratePrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        userAnswer = Console.ReadLine();

        dateText = _newDateLoader.GetDateText();

        SaveAnswer($"Date: {dateText}\nPrompt: {prompt}\nAnswer: {userAnswer}");
    }
    public void SaveAnswer(string userAnswer)
    {
        _userAnswerList.Add(userAnswer);
    }

    public void DisplayAnswerWithPromptAndDate()
    {
        Console.WriteLine(); // empty line
        foreach (string answer in _userAnswerList)
        {
            Console.WriteLine(answer);
        }
        Console.WriteLine(); // empty line
    }

    public void AskForFileNameAndSaveToFile()
    {
        Console.Write("Input filename: ");
        Utils.SaveFile(Console.ReadLine(), _userAnswerList);
    }
    
    public void AskForFileNameAndLoadFile()
    {
        Console.Write("Input filename: ");
        Utils.LoadFile(Console.ReadLine(), _userAnswerList);
    }

}