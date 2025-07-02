using System;

class Program
{
    static void Main(string[] args)
    {
     Console.Write("What is your grade percentage? ");
     string text = Console.ReadLine();
     int grade = int.Parse(text);
     string letter = "";
     string sign = "";
     int remainder = grade % 10;
     if (remainder >= 7)
     {
        sign = "+";
     }
     else if (remainder < 3)
     {
        sign = "-";
     }

     if (grade >= 90)
     {
        if (remainder < 3) 
        {
         letter = "A";
         sign = "-";
        }
        else
        {
         letter = "A";
         sign = "";
        }
     }
     else if (grade >= 80)
     {
        letter = "B";
     }
     else if (grade >= 70)
     {
        letter = "C";
     }
     else if (grade >= 60)
     {
        letter = "D";
     }
     else
     {
        letter = "F";
        sign = "";
     }

     Console.WriteLine($"Your score is {letter}{sign}");
     if (grade >= 70)
     {
        Console.Write("Congratulations, you passed this course");
     }
     else
     {
      Console.Write("Sorry, you failed this course. Try harder next time");
     }
    }
}  