using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    { 
        //To show creativity i added an extra activity called the walking activity where i encourage the user to take a short walk 
        // and focus on engaging each of their five senses. i programmed it in such a way that the duration the user chooses will be divided into 5 parts
        // and the user will be prompted to focus on each of their five senses for each part
        bool programRunning = true;
        while (programRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start Breathing Activity");
            Console.WriteLine("   2. Start Reflecting Activity");
            Console.WriteLine("   3. Start Walking Activity");
            Console.WriteLine("   4. Start Listing Activity");
            Console.WriteLine("   5. Quit");
            Console.Write("Please enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.", 10);
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other parts of your life ", 15);
                    reflectingActivity.Run();
                    break;
                case "3":
                    WalkingActivity walkingActivity = new WalkingActivity("Walking Activity", "This Activity will encourage you to take a short walk and focus on engaging each of your five senses.", 60);
                    walkingActivity.Run();
                    break;
                case "4":
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30, 5);
                    listingActivity.Run();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    Thread.Sleep(2000);
                    programRunning = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
        
        

    }
}