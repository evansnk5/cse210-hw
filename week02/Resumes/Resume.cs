using System;

public class Resume{

    public string _name = "";
    public List<Job> _jobs = new List<Job>(); 
    //johnsonHome._blinds.Add(kitchen);
    //double amount = johnsonHome._blinds[0].GetArea();

     public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }



    }
}
