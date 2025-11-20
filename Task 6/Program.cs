namespace Task_6
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter marks: ");
            string marksInput = Console.ReadLine();

            Console.Write("Enter total: ");
            string totalInput = Console.ReadLine();

            // Use TryParse
            bool marksSuccess = int.TryParse(marksInput, out int marks);
            bool totalSuccess = int.TryParse(totalInput, out int total);

            if (!marksSuccess || !totalSuccess)
            {
                Console.WriteLine("Invalid input! Please enter valid integers.");
                return;
            }

            // BREAKPOINT 1 Before calculation
            double percentage = (double)marks / total * 100;   // <-- integer division issue!

            // BREAKPOINT 2 After calculation
            Console.WriteLine($"Percentage: {percentage}%");
        }
    }

}
