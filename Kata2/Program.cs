namespace Kata2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Zätha";
        int level = 5;
        float healthPoints = 75.5f;
        double exp = 1025.75;
        bool hasMagic = true;
        char rank = 'A';
        
        Console.WriteLine($"Character Name: {name}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Health Points: {healthPoints}");
        Console.WriteLine($"Experience Points: {exp}");
        Console.WriteLine($"Has Magic Ability: {hasMagic}");
        Console.WriteLine($"Rank: {rank}");

        double nextLevel = 2000 - exp;
        
        Console.WriteLine($"Points needed to reach next level: {nextLevel}");

    }
}