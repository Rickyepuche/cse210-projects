using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment ass1 = new Assignment("Richard Edigin", "Multiplication");
        Console.WriteLine(ass1.GetSummary());

        // Now create the derived class assignments
        MathAssignment ass2 = new MathAssignment("Naomi Egbon", "Matrices And Determinants", "7.5", "7-19");
        Console.WriteLine(ass2.GetSummary());
        Console.WriteLine(ass2.GetHomeworkList());

        WritingAssignment ass3 = new WritingAssignment("Samule Osato", "Edo Language", "The Oba of Benin");
        Console.WriteLine(ass3.GetSummary());
        Console.WriteLine(ass3.GetWritingInformation());
    }
}