public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    //Added a display method to the resume class
    public void DisplayJobs()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job i in _jobs)
        {
           i.Display();
        }
    }
}