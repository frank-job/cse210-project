using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You have earned {_points + _bonus} points!");
            Console.WriteLine($"You finished the checklist bonus! +{_bonus}");
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public void SetAmountCompleted(int count)
    {
        _amountCompleted = count;
    }
}