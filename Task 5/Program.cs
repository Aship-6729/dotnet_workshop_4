using System;
using Task_5;


class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("Enter a day (e.g., Sunday): ");
        string dayInput = Console.ReadLine().Trim().ToLower();

        DayType dayType;

        if (dayInput == "friday" || dayInput == "saturday")
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine($"It is: {dayType}");
        Console.WriteLine();


        
        Book book1 = new Book("C# Fundamentals", "John Doe", 999.99);

        // Create second book using 'with' expression
        Book book2 = book1 with { title = "Advanced C#", price = 1499.49 };

        Console.WriteLine("First Book:");
        Console.WriteLine(book1);

        // Deconstruct second book
        var (title, author, price) = book2;

        Console.WriteLine("\nSecond Book (Deconstructed):");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}
