using System.Runtime;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        // attributes

        private int _amountCompleted;
        private int _target;
        private int _bonus;

        // constructor

        public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
        {
            _amountCompleted = amountCompleted;
            _target = target;
            _bonus = bonus;

        }

        // make some accessible properties

        public int AmountCompleted
        {
            get { return _amountCompleted; }
        }

        public int Target
        {
            get { return _target; }
        }

        public int Bonus
        {
            get { return _bonus; }
        }

        // methods

        public override void RecordEvent()
        {
            _amountCompleted++; // adds up every time an event is recorded 
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target; // true if we reached or exceeded the target
        }

        public override string GetDetailsString()
        {
            return $"Goal: {ShortName}\nDescription: {Description}\nPoints per Completion: {Points}\nTarget: {_target}\nBonus: {_bonus}\nCurrent Progress: {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation() // everything is override!
        {
            return $"{ShortName} ({Description}) ➜ Currently completed: {_amountCompleted}/{_target}";
        }
    }
}
