public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    public void  DisplayJobDetails()
    {
        // return $"{_jobTitle} at {_company} from {_startYear} to {_endYear}";
            Console.WriteLine($"{_jobTitle} at {_company} from {_startYear} to {_endYear}");

    }













}