using System;

class Program
{
    static void Main(string[] args)
    {
        
        // instantiate 

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        // call method

        string summary = assignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        string assignmentTitle = writingAssignment.GetWritingInformation();

        // print it

        Console.WriteLine();
        Console.WriteLine(summary);
        Console.WriteLine();
        Console.WriteLine(homeworkList);
        Console.WriteLine();
        Console.WriteLine(assignmentTitle);
        Console.WriteLine();

    }
}