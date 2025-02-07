using System;
using Microsoft.VisualBasic;

public class MathAssignment : Assignment 
{
    private string _textBooksection;
    private string _problem;

    public MathAssignment(string studentName, string topic, string textbooksection, string problem) 
        : base(studentName, topic)
    {
        _textBooksection = textbooksection;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section{_textBooksection} Problem {_problem}";
    }

}