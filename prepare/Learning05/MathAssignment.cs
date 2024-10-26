
using System.Security.Cryptography.X509Certificates;

public class MathAssignment : Assignment
{
    // attributes

    private string _textbookSection;
    private string _problems;

    // constructor

    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // method

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\nSection {_textbookSection} Problems {_problems}";
    } 

}