using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        int number = -1; 
        

        //create the list
        List<int> numberList  = new List<int>();
        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");

        while(number!= 0)
        {
            
              Console.Write("Enter number: ");

              string userNumbers =  Console.ReadLine();
              number = int.Parse(userNumbers);

              if(number !=0){ 
                
                  numberList.Add(number);
            
        //  if (number==0)
        //      break;
        }
        }
        // Part 2: Compute the sum
             int sum=0;

             foreach(int loopNumber in numberList){
             sum += loopNumber;
        }
           Console.WriteLine($"The sum is {sum}");

        // Part 2: Compute the average
        float average = ((float)sum)/numberList.Count;
        Console.WriteLine($"The average is: {average}");

        // Check for the max number
         int max = numberList[0];

         foreach (int loopNumber in numberList)
        {
            if (loopNumber > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}