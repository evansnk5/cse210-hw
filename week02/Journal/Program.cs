using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is my journal program.");


        Journal theJournal = new Journal();

        string userChoice = "";
        while (userChoice != "5")
        {
            Console.WriteLine("Please choose an option :");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");
            userChoice = Console.ReadLine();
            // Console.WriteLine(userChoice);

            switch (userChoice)
            {
                case "1":
                    theJournal.AddEntry();
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the file name to save to: ");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    break;
                case "4":
                    Console.Write("Enter the file name to load from: ");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Goodbye!");
        }
    }
}