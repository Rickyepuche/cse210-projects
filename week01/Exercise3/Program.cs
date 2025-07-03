using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO GUESS MY NUMBER GAME!");
        Console.WriteLine();

        string start = "yes";
        while (start != "no")
        {
            int guess = 0;
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 101);
            int guessTaken = 0;
            do
            {
                Console.Write("What is your guess? ");
                string text = Console.ReadLine();
                guess = int.Parse(text);
                guessTaken++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it!. It took you {guessTaken} guesses");
                    Console.Write("Do you want to play again?(yes/no) ");
                    string text2 = Console.ReadLine();
                    start = text2.ToLower();
                    Console.WriteLine();
                }
            } while (guess != magicNumber);
        }
    }
}