
namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        // attributes

            private bool _isComplete;

        // contstructor

            public SimpleGoal(string name, string description, string points) : base(name, description, points)
            {
                _isComplete = false; // begins incomplete 
            }

        // methods

        public override void RecordEvent()
        {
            _isComplete = true; // because a completed goal is recorded 
        }

        public override bool IsComplete()
        {
            return _isComplete; // returning the status of whether this goal has been recorded as complete
        }

        public override string GetStringRepresentation()
        {
            return $"{ShortName} ({Description})";
        }
    } 
}
