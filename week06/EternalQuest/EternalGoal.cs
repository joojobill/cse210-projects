namespace EternalQuestProgram
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            // Eternal goals are never complete, just record the event
        }

        public override bool IsComplete()
        {
            return false; // Eternal goals are never complete
        }

        public override string GetDetailsString()
        {
            return $"{_shortName}: {_description} - Eternal Goal";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{_shortName},{_description},{_points}";
        }
    }
}