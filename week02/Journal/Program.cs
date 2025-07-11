using System;

class Program
{
    static void Main(string[] args)
    {   
        //I added code to check for file not found error when loading from a file.
        //I added code that continously runs the program unless they chose to quit
        //I added code to prompt the user to write an entry if they try to display without first writing an entry
        //I added code to ensure user  save any entries they made before quitting but only if the entry is not empty. 
        //so if no  entry was made. it quits the program without asking the user to save.

        int choice = 0;
        Journal userJournal = new Journal();


        while (choice != 6)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you want to do? ");
            string text1 = Console.ReadLine();
            choice = int.Parse(text1);

            Entry userEntry = new Entry();
            PromptGenerator aRandomPrompt = new PromptGenerator();
        
            if (choice == 1)
            {
                userEntry._promptText = aRandomPrompt.GetRandomPrompt();
                Console.WriteLine(userEntry._promptText);
                Console.Write("> ");
                userEntry._entryText = Console.ReadLine();
                userJournal.AddEntry(userEntry);
            }
            else if (choice == 2)
            {          
                if (userJournal._entries.Count < 1)
                {
                    Console.WriteLine("There are no entries. Please make an entry.");
                }
                else
                {
                    userJournal.DisplayAll();
                }
            }
            else if (choice == 3)
            {
                try
                {
                    Console.WriteLine("What is the filename? ");
                    string fileName = Console.ReadLine(); 
                    userJournal.LoadFromFile(fileName);
                    Console.WriteLine();
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("File not found (make sure to add the file extension!)" + ex.FileName);
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                userJournal.SaveToFile(fileName);
            }
            else if (choice == 5)
            {
                if (userJournal._entries.Count > 0)
                {
                    Console.Write("Do you want to save before exiting? (yes/no): ");
                    string response = Console.ReadLine().ToLower();
                    if (response == "yes")
                    {
                        Console.Write("Enter filename: ");
                        string fileName = Console.ReadLine();
                        userJournal.SaveToFile(fileName);
                    }
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
                choice = 6;
            }
            Console.WriteLine();
        }
    }
}