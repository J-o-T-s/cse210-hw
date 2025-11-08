using System;

public class PromptGenerator
{
    public List<string> promptList = new List<string>()
    {
        "What is one thing you would like to do today?",
        "What was the most meaningful conversation you had today?",
        "What made you smile today?",
        "What is something new you learned today?",
        "Describe a challenge you faced today and how you handled it.",
        "What are you grateful for today?",
        "What is something kind someone did for you today?",
        "How did you help someone else today?",
        "What was the most peaceful moment of your day?",
        "What is one goal you want to accomplish tomorrow?",
        "What is something that inspired you today?",
        "Describe your current mood and what influenced it.",
        "What was the best decision you made today?",
        "If you could relive one moment from today, what would it be?",
        "What is something you're looking forward to?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    }; // Questions were gotten from chatGPT and assignment

    public string GeneratePrompt()
    {
        Random newRandom = new Random();
        int indexChoice = newRandom.Next(0, promptList.Count);

        return promptList[indexChoice];
    }
}