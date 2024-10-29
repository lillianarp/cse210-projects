
namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        // attributes

        private int _timesRecorded; // EXCEEDING REQUIREMENTS: A different kind of counter

        // constructor

        public EternalGoal(string name, string description, string points) : base(name, description, points)
        {
            _timesRecorded = 0;
        }

        // methods

        public override void RecordEvent()
        {
            _timesRecorded++; 
        }

        public override bool IsComplete()
        {
            return false; // this goal is supposed to be incomplete
        }

        public override string GetStringRepresentation()
        {
            return $"{ShortName} ({Description}) {GetProgressRepresentation()}";
        }

        public string GetProgressRepresentation() // Setting up a simple, visual counter system
        {
            int bars = _timesRecorded / 100; // each bar = 100 completions
            int remainingTimes = _timesRecorded % 100; 

            int dashes = remainingTimes / 10; // each dash is 10 completions
            int dots = remainingTimes % 10; // each dot represents 1 completion 

            // here's what the markers look like
            return new string('|', bars) + new string('-', dashes) + new string('.', dots);
        }

    }
}
