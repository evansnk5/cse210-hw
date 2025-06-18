public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _target)
            return _points + _bonus;
        else
            return _points;
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override string GetStatus()
    {
        return IsComplete() ? "[X]" : "[ ]";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_timesCompleted}|{_target}|{_bonus}";
    }
}
