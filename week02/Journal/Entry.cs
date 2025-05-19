// Entry: Represents a single journal entry.
using System;
using System.Collections.Generic;
public class Entry
{
     public string _promptText;
    public string _date;

     public string _entryText;

    public Entry(string prompt, string response)
    {
        _promptText = prompt;
        _entryText = response;
        _date = DateTime.Now.ToShortDateString();

    }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date}  Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine();
    }
}