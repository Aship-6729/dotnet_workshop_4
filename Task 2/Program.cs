namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Calculator c= new Calculator();
            
            c.PrintWelcome();
            Console.WriteLine($"\nAddition: {c.Add(5, 10)}\nMultiplication: {c.Multiply(5,7)}\n");
        }
    }
}
