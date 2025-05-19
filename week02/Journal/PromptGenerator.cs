//PromptGenerator: Supplies random prompts whenever needed.
using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public  List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "What are you grateful for?",
        "What was the most challenging part of your day?",
        "What is something you want to improve on?",
        "If I had one thing I could do over today, what would it be?",
        "What challenge did I face today and how did I handle it?",


    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }
}