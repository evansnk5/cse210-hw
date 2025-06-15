using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random;


    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",  0)  
    {
        _prompts = new List<string>
        {
            "List your favorite hobbies.",
            "List things you are grateful for.",
            "List your goals for the next year.",
            "List your favorite books or movies.",
            "List skills you want to learn."
        };
        _random = new Random();
    }
    public void Run() {
        
        DisplayStartingMessage();
        Console.WriteLine($"\nPrompt: {_prompts[_random.Next(_prompts.Count)]}");
        Console.WriteLine("Start listing items...");
        ShowCountDown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        DisplayEndingMessage();
    }
    }
// public class ListingActivity : Activity
// {
//     private List<string> _prompts;
//     private Random _random;

//     public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
//     {
//         _prompts = new List<string>
//         {
//             "Who are people that you appreciate?",
//             "What are personal strengths of yours?",
//             "Who are people that you have helped this week?",
//             "When have you felt the Holy Ghost this month?",
//             "Who are some of your personal heroes?"
//         };
//         _random = new Random();
//     }

//     public void Run()
//     {
//         DisplayStartingMessage();
//         Console.WriteLine($"\nPrompt: {_prompts[_random.Next(_prompts.Count)]}");
//         Console.WriteLine("Start listing items...");
//         ShowCountDown(5);

//         int count = 0;
//         DateTime endTime = DateTime.Now.AddSeconds(_duration);
//         while (DateTime.Now < endTime)
//         {
//             Console.Write("> ");
//             Console.ReadLine();
//             count++;
//         }

//         Console.WriteLine($"You listed {count} items.");
//         DisplayEndingMessage();
//     }
// }