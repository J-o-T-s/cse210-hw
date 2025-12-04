using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("This goal has already been completed.");
        }
        else
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {GetPoints()}pts!");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}
