
namespace EternalQuest
{
    public abstract class Goal
    {
        // attributes

        protected string _shortName;
        protected string _description;
        protected string _points;

        // constructor

        public Goal(string name, string description, string points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public string ShortName // because we need _shortName in GoalManager; accessor property
        {
            get { return _shortName; }
        }

        public string Description
        {
            get { return _description; }
        }

        public string Points
        {
            get { return _points; }
        }

        // methods

        public abstract void RecordEvent(); // these two need to be abstract
        public abstract bool IsComplete(); // because the subclasses shall provide 
        public abstract string GetStringRepresentation();

        public virtual string GetDetailsString() // not abstract, because EternalGoal and SimpleGoal don't need this method
        {
            return ""; // default output (that doesn't do anything)
        } 
    
    }
}
