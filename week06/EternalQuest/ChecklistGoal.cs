using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
    : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    
    public override void RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("This goal has already been completed.");
        }
        else
        {
            _amountCompleted++;
            Console.WriteLine($"Congratulations! You have earned {GetPoints()}pts!");
            if (IsComplete()) // redundan, but please permit me :)
            {
                Console.WriteLine($"You have completed the checklist and earned a bonus of {_bonus}pts!");
            }
        }
    }
    
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }
    
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()} ({GetDescription()}) —— Currently completed: {_amountCompleted}/{_target} ~ {GetPoints()}pts | bonus: {_bonus}pts";
    }
}