// A simple program that generates a random number and asks the user to guess it.
// Author: Josh Tuks

using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfGuesses;

        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        numberOfGuesses = 0;

        Console.Write("What is your magic number? ");
        int userGuess = int.Parse(Console.ReadLine());

        while (userGuess != randomNumber)
        {
            if (userGuess < randomNumber)
            {
                numberOfGuesses ++;
                Console.WriteLine("Higher");
            }
            else if (userGuess > randomNumber)
            {
                numberOfGuesses ++;
                Console.WriteLine("Lower");
            }
            Console.Write("What is your magic number? ");
            userGuess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"Guesses: {numberOfGuesses}");

        string playAgain;
        do
        {
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();
            if (playAgain == "yes")
            {
                randomNumber = random.Next(1, 11);
                numberOfGuesses = 0;
                Console.Write("What is your magic number? ");
                userGuess = int.Parse(Console.ReadLine());
                
                while (userGuess != randomNumber)
                {
                    if (userGuess < randomNumber)
                    {
                        numberOfGuesses ++;
                        Console.WriteLine("Higher");
                    }
                    else if (userGuess > randomNumber)
                    {
                        numberOfGuesses ++;
                        Console.WriteLine("Lower");
                    }
                    Console.Write("What is your magic number? ");
                    userGuess = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Guesses: {numberOfGuesses}");
            }
        } while (playAgain == "yes");
    }
}