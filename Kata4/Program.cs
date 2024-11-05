namespace Kata4;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 2; i++)
        {
            Console.WriteLine($"Wave {i} is starting!");
            for (int j = 1; j <= 4; j++)
            {
                Console.WriteLine($"   Enemy #{j} has spawned.");
            }
            Console.WriteLine($"Wave {i} completed. Preparing for hte next wave...");
            Console.WriteLine();
            Thread.Sleep(1000);
        }
        Console.WriteLine("All waves completed! Victory is yours!");
    }
}