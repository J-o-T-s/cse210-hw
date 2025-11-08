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

        dateText = _newDateLoader.getDateText();

        SaveAnswer($"Date: {dateText}\nPrompt: {prompt}\n{userAnswer}");
    }
    public void SaveAnswer(string userAnswer)
    {
        _userAnswerList.Add(userAnswer);
    }

    public void DisplayAnswerWithPromptAndDate()
    {
        foreach (string answer in _userAnswerList)
        {
            Console.WriteLine(answer);
        }
    }

    public void AskForFileNameAndSaveToFile()
    {
        
    }
    
    public void AskForFileNameAndLoadFile()
    {
        
    }

}