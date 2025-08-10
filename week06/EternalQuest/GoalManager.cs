using System.IO;

public class GoalManager
{
    private List<Goals> _goals = new List<Goals>();
    private int _score = 0;

    //constructor

    //methods
    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.WriteLine();
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. CheckList Goal");
        Console.WriteLine("  4. Bad Habit Goal");
        Console.WriteLine();
    }
    public void ListGoalDetails()
    {
        int count = 1;
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        foreach (Goals goal in _goals)
        {
            Console.Write($"{count}. ");
            Console.WriteLine(goal.GetDetailsString());
            count++;
        }
        Console.WriteLine();
    }
    public void CreateGoal()
    {
        ListGoalNames();
        Console.Write("What type of goal would you want to create? ");
        string goalType = Console.ReadLine();
        Console.WriteLine();
        try
        {
            if (goalType == "1")
            {
                Console.Write("What is the name of your goal? ");
                string theName = Console.ReadLine();
                Console.Write("Give a short description: ");
                string theDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string text99 = Console.ReadLine();
                if (!int.TryParse(text99, out int thePoints))
                {
                    Console.WriteLine("Invalid input for points. Please enter a valid integer.");
                    return;
                }
                SimpleGoals simp = new SimpleGoals(theName, theDescription, thePoints);
                _goals.Add(simp);
            }
            else if (goalType == "2")
            {
                Console.Write("What is the name of your goal? ");
                string theName = Console.ReadLine();
                Console.Write("Give a short description: ");
                string theDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string text3 = Console.ReadLine();
                if (!int.TryParse(text3, out int thePoints))
                {
                    Console.WriteLine("Invalid input for points. Please enter a valid integer.");
                    return;
                }
                EternalGoals eternal = new EternalGoals(theName, theDescription, thePoints);
                _goals.Add(eternal);
            }
            else if (goalType == "3")
            {
                Console.Write("What is the name of your goal? ");
                string theName = Console.ReadLine();
                Console.Write("Give a short description: ");
                string theDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string text5 = Console.ReadLine();
                if (!int.TryParse(text5, out int thePoints))
                {
                    Console.WriteLine("Invalid input for points. Please enter a valid integer.");
                    return;
                }
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string text11 = Console.ReadLine();
                if (!int.TryParse(text11, out int theTarget))
                {
                    Console.WriteLine("Invalid input for target. Please enter a valid integer.");
                    return;
                }
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string text6 = Console.ReadLine();
                if (!int.TryParse(text6, out int theBonus))
                {
                    Console.WriteLine("Invalid input for bonus. Please enter a valid integer.");
                    return;
                }
                CheckListGoals checker = new CheckListGoals(theName, theDescription, thePoints, theTarget, theBonus);
                _goals.Add(checker);
            }
            else if (goalType == "4")
            {
                Console.Write("What is the name of the bad habit you want to end? ");
                string theName = Console.ReadLine();
                Console.Write("Give a short description: ");
                string theDescription = Console.ReadLine();
                Console.Write("What is the maximum allowed strikes? ");
                string textStrikes = Console.ReadLine();
                if (!int.TryParse(textStrikes, out int allowedStrikes))
                {
                    Console.WriteLine("Invalid input for allowed strikes. Please enter a valid integer.");
                    return;
                }
                Console.Write("What is the amount of points to lose if totally failed to stop habit? ");
                string textPoints = Console.ReadLine();
                if (!int.TryParse(textPoints, out int thePoints))
                {
                    Console.WriteLine("Invalid input for points. Please enter a valid integer.");
                    return;
                }
                BadHabitGoal bhg = new BadHabitGoal(theName, theDescription, allowedStrikes, thePoints);
                _goals.Add(bhg);

            }
            else
            {
                Console.WriteLine("Invalid goal type selected.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while creating the goal: {ex.Message}");
        }
    }
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish, or did you repeat a bad habit? ");
        string goalEvent = Console.ReadLine();
        if (!int.TryParse(goalEvent, out int fakeIndex))
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
            return;
        }
        int index = fakeIndex - 1;
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Goal number out of range.");
            return;
        }
        try
        {
            Goals accGoal = _goals[index];
            accGoal.RecordEvent();
            _score = _score + accGoal.GetScore();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while recording the event: {ex.Message}");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the name of the txt file? ");
        string filename = Console.ReadLine();
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goals goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Your goals have been saved");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }
    public void LoadGoals()
    {
        Console.Write("Enter the name of file you want to load from: ");
        string filename = Console.ReadLine();
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File does not exist.");
                return;
            }
            string[] lines = System.IO.File.ReadAllLines(filename);
            if (lines.Length == 0)
            {
                Console.WriteLine("File is empty.");
                return;
            }
            if (!int.TryParse(lines[0], out int score))
            {
                Console.WriteLine("First line in file is not a valid score.");
                return;
            }
            _score = score;
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');
                if (parts.Length < 2)
                {
                    Console.WriteLine($"Invalid line format at line {i + 1}.");
                    continue;
                }
                string goalsType = parts[0];
                string splitWhat = parts[1];
                try
                {
                    if (goalsType == "SimpleGoal")
                    {
                        string[] goalDetails = splitWhat.Split('|');
                        if (goalDetails.Length < 4)
                        {
                            Console.WriteLine($"Invalid SimpleGoal format at line {i + 1}.");
                            continue;
                        }
                        string name = goalDetails[0];
                        string description = goalDetails[1];
                        if (!int.TryParse(goalDetails[2], out int points))
                        {
                            Console.WriteLine($"Invalid points for SimpleGoal at line {i + 1}.");
                            continue;
                        }
                        if (!bool.TryParse(goalDetails[3], out bool isComplete))
                        {
                            Console.WriteLine($"Invalid isComplete for SimpleGoal at line {i + 1}.");
                            continue;
                        }
                        SimpleGoals dd = new SimpleGoals(name, description, points);
                        dd.SetIsComplete(isComplete);
                        _goals.Add(dd);
                    }
                    else if (goalsType == "EternalGoal")
                    {
                        string[] goalDetails = splitWhat.Split('|');
                        if (goalDetails.Length < 3)
                        {
                            Console.WriteLine($"Invalid EternalGoal format at line {i + 1}.");
                            continue;
                        }
                        string name = goalDetails[0];
                        string description = goalDetails[1];
                        if (!int.TryParse(goalDetails[2], out int points))
                        {
                            Console.WriteLine($"Invalid points for EternalGoal at line {i + 1}.");
                            continue;
                        }
                        EternalGoals pp = new EternalGoals(name, description, points);
                        _goals.Add(pp);
                    }
                    else if (goalsType == "CheckListGoal")
                    {
                        string[] goalDetails = splitWhat.Split('|');
                        if (goalDetails.Length < 6)
                        {
                            Console.WriteLine($"Invalid CheckListGoal format at line {i + 1}.");
                            continue;
                        }
                        string name = goalDetails[0];
                        string description = goalDetails[1];
                        if (!int.TryParse(goalDetails[2], out int points))
                        {
                            Console.WriteLine($"Invalid points for CheckListGoal at line {i + 1}.");
                            continue;
                        }
                        if (!int.TryParse(goalDetails[3], out int target))
                        {
                            Console.WriteLine($"Invalid target for CheckListGoal at line {i + 1}.");
                            continue;
                        }
                        if (!int.TryParse(goalDetails[4], out int bonus))
                        {
                            Console.WriteLine($"Invalid bonus for CheckListGoal at line {i + 1}.");
                            continue;
                        }
                        if (!int.TryParse(goalDetails[5], out int amountCompleted))
                        {
                            Console.WriteLine($"Invalid amountCompleted for CheckListGoal at line {i + 1}.");
                            continue;
                        }
                        CheckListGoals gg = new CheckListGoals(name, description, points, target, bonus);
                        gg.SetAmountCompleted(amountCompleted);
                        _goals.Add(gg);
                    }

                    else if (goalsType == "BadHabitGoal")
                    {
                        string[] goalDetails = splitWhat.Split('|');
                        if (goalDetails.Length < 6)
                        {
                            Console.WriteLine($"Invalid BadHabitGoal format at line {i + 1}.");
                            continue;
                        }
                        string name = goalDetails[0];
                        string description = goalDetails[1];
                        if (!int.TryParse(goalDetails[2], out int allowedStrikes))
                        {
                            Console.WriteLine($"Invalid allowedStrikes for BadHabitGoal at line {i + 1}.");
                            continue;
                        }
                        if (!int.TryParse(goalDetails[3], out int points))
                        {
                            Console.WriteLine($"Invalid points for BadHabitGoal at line {i + 1}.");
                            continue;
                        }
                        if (!int.TryParse(goalDetails[4], out int currentStrikes))
                        {
                            Console.WriteLine($"Invalid currentStrikes for BadHabitGoal at line {i + 1}.");
                            continue;
                        }
                        if (!bool.TryParse(goalDetails[5], out bool isComplete))
                        {
                            Console.WriteLine($"Invalid isComplete for BadHabitGoal at line {i + 1}.");
                            continue;
                        }
                        BadHabitGoal bhg = new BadHabitGoal(name, description, allowedStrikes, points);
                        bhg.SetCurrentStrikes(currentStrikes);
                        bhg.SetIsComplete(isComplete);
                        _goals.Add(bhg);
                    }
                    else
                    {
                        Console.WriteLine($"Unknown goal type '{goalsType}' at line {i + 1}.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading goal at line {i + 1}: {ex.Message}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
        }
    }
}