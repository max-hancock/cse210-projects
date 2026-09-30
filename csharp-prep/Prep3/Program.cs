using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
}

public class Resume
{
    public string _name;
    public List<Job> _Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_Jobs}:");

        foreach (Job job in _Jobs)
        {
            job.Display();
        }
    }

}

