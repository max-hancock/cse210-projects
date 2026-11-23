public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return -GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[-] {GetName()} ({GetDescription()}) -- lose {GetPoints()} points each time";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}