using System;
using System.ComponentModel;
using System.Data;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        //I added an extra class clalled the Library class. This class reads from a file called passages.txt. I thereafter 
        //added a feature that allows the user to select a scripture passage by entering a number from 0 to 19. This offers
        //a variety to scriptures to memorise and a good user experience. I maintained the priciples of encapsulation and abstraction.

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Select a scripture by writing a number from 0 to 19.");
        string textPassage = Console.ReadLine();
        int masteryPassage = int.Parse(textPassage);
        Library l = new Library(masteryPassage);
        string book = l.GetBook();
        int chapter = l.GetChapter();
        int startVerse = l.GetStartVerse(); 
        int endVerse = l.GetEndVerse(); 
        string verseText = l.GetVerseText();
        Reference r = new Reference(book, chapter, startVerse, endVerse);
        Scripture s = new Scripture(r, verseText);
        Console.WriteLine(s.GetDisplayText());
        Console.WriteLine("Press Enter to continue or type quit to finish:");
        string text = Console.ReadLine();
        int numberToHide = 3;
        while (text != "quit")
        {
            if (text == "")
            {
                Random rnd = new Random();
                s.HideRandomWords(numberToHide);
                Console.Clear();
                Console.WriteLine("Welcome to the Scripture Memorizer!");
                Console.WriteLine(s.GetDisplayText());
                Console.WriteLine("Press Enter to hide or type quit to finish:");

                if (s.IsCompletelyHidden() == true)
                {
                    break;
                }
            }
            numberToHide = numberToHide +2;
            text = Console.ReadLine();
            Console.Clear();

        }
    }
    
}