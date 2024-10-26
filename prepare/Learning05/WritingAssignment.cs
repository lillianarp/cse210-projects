
public class WritingAssignment : Assignment
    {
        // attributes

        private string _title;

        // constructor

        public WritingAssignment(string name, string topic, string title) : base(name, topic)
        {
            _title = title;
        } 

        // method

        public string GetWritingInformation()
        {
            return $"{_studentName} - {_topic}\n{_title}";
        }

    }
