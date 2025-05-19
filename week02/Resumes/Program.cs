using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Resume Builder!");

        // Create a new Job object
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // Display the job information
        job1.DisplayJobDetails();

        // Create another Job object
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //create a new Resume object
        Resume myResume = new Resume();
        myResume._name = "Evans Nkrumah";

        // Add the jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        // Display the resume information   
        myResume.Display();








          
    }
}