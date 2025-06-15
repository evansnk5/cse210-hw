public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    var reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case "3":
                    var listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    Thread.Sleep(2000);
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the main menu...");
                Console.ReadLine();
            }
        }
    }
}
