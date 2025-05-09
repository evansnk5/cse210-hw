using System;

class Program
{
    static void Main(string[] args)
    {
        
       Console.WriteLine("---- Welcome To Guessing Game------");




        // generating random numbers
       Random numberGen = new Random();
       int magicNumber = numberGen.Next(1,101);

       //Declaring and intializing the guess
       int guess = -1;

       while( guess != magicNumber ) {
        Console.WriteLine(" What is the magic number?");
        Console.Write(" What is your guess? : " );
        guess = int.Parse(Console.ReadLine());
        
        if (magicNumber> guess){
            Console.WriteLine(" Higher");
        }
        else if (magicNumber<guess){
            Console.WriteLine(" Lower");
        }
        else{
            Console.WriteLine(" You guessed it!");
        }
        
       }

    //         if (guess <= magicNumber){
    //         Console.Write("Higher!");
    //     }
    //     else{
    //         Console.Write("Lower!");
    //     }

    //     } while ( guess != magicNumber);
       
    //    int mag = 6;
    //    Console.WriteLine(" What is the magic number?");
    //    Console.Write("  What is your guess? : " );
    //    string inputt= Console.ReadLine();
    //     int userGuess = int.Parse(inputt);

    //    if(userGuess > mag){
    //     Console.Write("Lower");

    //    }
    //    else if (userGuess < mag){
    //     Console.Write("Higher");
    //    }
    //    else{
    //     Console.Write("  You guessed it!");
    //    }
       




    }
}