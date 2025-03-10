class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress on {_shortName}. You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals never get "completed"
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}
