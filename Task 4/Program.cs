namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Player p1 = new Player();// obj using default constructor.
            Player p2 = new Player("Hero", 10, 100); // obj using parameterized constructor.

            Console.WriteLine($"Player 1: Name={p1.playerName}, Level={p1.level}, Health={p1.health}");
            Console.WriteLine($"Player 2: Name={p2.playerName}, Level={p2.level}, Health={p2.health}");
        }
    }
}
