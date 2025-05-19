// Journal: Stores a list of journal entries
using System;
using System.Collections.Generic;using System.IO;



public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "What are you grateful for?",
        "What was the most challenging part of your day?",
        "What is something you want to improve on?",
        "If I had one thing I could do over today, what would it be?",
        "What challenge did I face today and how did I handle it?",
    };

    public string _fileName;
    public string _prompt;
    public string _date;
    public string _response;

    // public void AddEntry(Entry newEntry)

    // {
    //     _entries.Add(newEntry);
    //     Console.WriteLine("Entry added.");
    // }
    public void AddEntry()
    {
        Console.WriteLine("Enter a prompt: ");
        _prompt = Console.ReadLine();
        Console.WriteLine("Enter a response: ");
        _response = Console.ReadLine();
        Entry newEntry = new Entry(_prompt, _response);
        _entries.Add(newEntry);
        Console.WriteLine("Entry added.");
    }


    public void DisplayAll()

    {
        foreach (Entry entry in _entries)
        {
            // Console.WriteLine(entry);
            entry.Display();

        }
    }


    public void LoadFromFile(string file)
    {
        _entries.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                string prompt = parts[0];
                string response = parts[1];
                string date = parts[2];
                Entry entry = new Entry(prompt, response);
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Entries loaded from file.");
    }


    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._promptText}|{entry._entryText}|{entry._date}");

            }
            Console.WriteLine("Entries saved to file.");
        }
    }
}