
public class Assignment 
{
    // attributes

    protected string _studentName;
    protected string _topic; 

    // constructor

    public Assignment(string name, string topic) // constructor must always be named after the class 
    {
        _studentName = name;
        _topic = topic;
    }

    // method

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}