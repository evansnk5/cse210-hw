using System;
using System.Collections.Generic;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWrtingInformation()
    {
        return $"Title: {_title}\n" +
               $"{GetSummary()}";
    }
  }


