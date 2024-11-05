namespace MiniKata4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Spawning enemies using a for loop:");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Enemy #{i} spawned!");
        }
        
        Console.WriteLine();
        
        Console.WriteLine("Spawning enemies using a while loop:");

        int enemyCounter = 1;
        int maxEnemys = 4;
        
        while (enemyCounter < maxEnemys)
        {
            Console.WriteLine($"Enemy #{enemyCounter} spawned!");
            enemyCounter++;
        }
    }
}