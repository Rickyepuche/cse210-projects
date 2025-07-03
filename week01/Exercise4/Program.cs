using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //I completed the core requirements and the stretch challenges
        List<int> numbers = new List<int>();

        int userNumber = 9999;
        while (userNumber != 0)
        {
            Console.Write("Enter Number: ");
            string text = Console.ReadLine();
            userNumber = int.Parse(text);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        int average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max) 
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        int minPositiveNum = 9999;
        foreach (int number in numbers)
        {
            if (number > 0) 
            {
                if (number < minPositiveNum)
                {
                    minPositiveNum = number;
                }
            } 
        }
        Console.WriteLine($"The smallest positive number is: {minPositiveNum}");

        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}