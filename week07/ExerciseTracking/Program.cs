using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity runningExercise = new RunningActivity("Running Exercise", "This Running exercise will increase Endurance and improve the body", 60, 5);
        activities.Add(runningExercise);
        CyclingActivity cyclingExercise = new CyclingActivity("Cycling Exercise", "Thiis cycling exercise will help in cardiovascular endurance", 20, 10);
        activities.Add(cyclingExercise);
        SwimmingActivity swimmingExercise = new SwimmingActivity("Swimming Exercise", "This swimming exercise will help in blood flow through out the body and help develop lung endurance", 30, 8);
        activities.Add(swimmingExercise);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}