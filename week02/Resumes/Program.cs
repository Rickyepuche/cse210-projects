using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2023;
        job2._endYear = 2024;
        
        Job job3 = new Job();
        job3._company = "Amazon";
        job3._jobTitle = "Software Engineer";
        job3._startYear = 2024;
        job3._endYear = 2026;  

        Resume resume1 = new Resume();
        resume1._name = "Richard Edigin";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);
        resume1.DisplayJobs();
    }
}