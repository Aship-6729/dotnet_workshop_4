namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            ParameterDemo pd = new ParameterDemo();
            int number = 5;

            Console.WriteLine($"Original number: {number}");
            pd.Increase(ref number);
            Console.WriteLine($"After Increase method: {number}");
            Console.WriteLine();

            pd.GetFullName(out string fullName);
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine();

            int sum1 = pd.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum of 1,2,3,4,5: {sum1}");
        }
    }
}
