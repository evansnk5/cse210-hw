using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    List<string> _prompts;
    List<string> _questions;
    private Random _random;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on the good things in your life by having you think deeply about your experiences.", 0)
    {
        _prompts = new List<string>
        {
            "Think about a time you faced a challenge. What did you learn from it?",
            "Reflect on a moment of joy in your life. What made it special?",
            "Consider a time when you helped someone. How did it make you feel?",
            "Think about a failure you experienced. What did it teach you?"
        };

        _questions = new List<string>
        {
            "What was the most significant part of this experience?",
            "How did this experience change your perspective?",
            "What would you do differently if faced with a similar situation again?",
            "How can you apply what you've learned to future challenges?"
        };
        _random = new Random();
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"\nPrompt: {_prompts[_random.Next(_prompts.Count)]}");
        ShowSpinner(5);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine($"\n{question}");
            ShowSpinner(5);
            elapsed += 5;
        }
        DisplayEndingMessage();
    }

}
   