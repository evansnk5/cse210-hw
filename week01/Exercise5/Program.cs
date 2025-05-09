using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squaredNumber = SquareNumber(userNum);

        DisplayResult(userName,squaredNumber);  

    }
    
        //Creating functions
        static void DisplayWelcome (){
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName(){
            Console.Write("What is your name? :");
            string name = Console.ReadLine();
            return name;

        }
        static int PromptUserNumber(){
            Console.Write("What is your favorute number? :");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static int SquareNumber(int number){

            int square =number*number;
            return square;

        }
        static void  DisplayResult( string name, int square){
            Console .Write($"{name}, the square of your number is {square}");

        }



}