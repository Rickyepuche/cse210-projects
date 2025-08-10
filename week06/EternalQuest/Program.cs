// To show creativity, I added the BadHabitGoal class.
// BadHabitGoal allows users to track and reduce bad habits by setting a maximum number of allowed strikes.
// it is similar to the eternal goal, Each time the bad habit is performed, a strike is recorded. If the user stays under the limit, they succeed.
// If the limit is reached, the goal is marked as failed and points are subtracted, with uplifting messages provided throughout.
using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        GoalManager sss = new GoalManager();
        while (running)
        {
            sss.DisplayPlayerInfo();
            sss.Start();
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    sss.CreateGoal();
                    break;
                case "2":
                    sss.ListGoalDetails();
                    break;
                case "3":
                    sss.SaveGoals();
                    break;
                case "4":
                    sss.LoadGoals();
                    break;
                case "5":
                    sss.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Thank you for using the program");
                    Thread.Sleep(2000);
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}