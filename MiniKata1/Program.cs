namespace MiniKata1;

class Program
{
    static void Main(string[] args)
    {
        string name = "Zätha";
        int health = 100;
        float attackPower = 15.5f;
        bool isParalised = true;
        double coin = 24.75;
        
        Console.WriteLine($"Character Name: {name}");
        Console.WriteLine($"Character Health: {health}");
        Console.WriteLine($"Character Attack Power: {attackPower}");
        Console.WriteLine($"Character Is Paralised: {isParalised}");
        Console.WriteLine($"Charater Coin: {coin}");
    }
}