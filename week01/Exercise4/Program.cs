// A simple program to get a list of numbers and perform arithmetic operations,
// such as sum, average, largest number etc.

// Author: Josh Tuks

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int userInput;

        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numberList.Add(userInput);
            }
        } while (userInput != 0);
        
        float sum;
        float averageNumber;
        int largestNumber;

        int smallestPositiveNumber;
        List<int> sortedNumberList = new List<int>(numberList);
        sortedNumberList.Sort();
        
        sum = 0.0F;
        foreach (int number in numberList)
        {
            sum += number;
        }

        largestNumber = 0;
        foreach (int number in numberList)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        smallestPositiveNumber = largestNumber;
        foreach (int number in numberList)
        {
            if (number < smallestPositiveNumber && number > 0)
            {
                smallestPositiveNumber = number;
            }
        }

        float numberListLength = numberList.Count;
        averageNumber = sum / numberListLength;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {averageNumber}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine($"The sorted is list is:");
        foreach (int number in sortedNumberList)
        {
            Console.WriteLine(number);
        }
    }
}