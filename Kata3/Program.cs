namespace Kata3;

class Program
{
    static void Main(string[] args)
    {
        var rand = new Random();

        int playerLuck = rand.Next(1, 11);
        
        Console.WriteLine("You find a mysterious treasure chest! What will you do?");
        Console.WriteLine("1. Open the chest");
        Console.WriteLine("2. Ignore the chest");
        Console.WriteLine("3. Leave the area");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.WriteLine("You try to open the chest...");
            if (playerLuck > 7)
            {
                Console.WriteLine("You found a rare gem");
            }
            else if (playerLuck >= 5 && playerLuck < 7)
            {
                Console.WriteLine("You found some gold");
            }
            else
            {
                Console.WriteLine("The chest was trapped all hte loot was destroyed");
            }
        }
        else if (input == "2")
        {
            Console.WriteLine("You continue on your journey");
        }
        else if (input == "3")
        {
            Console.WriteLine("The mystery was left unsolved");
        }
        else
        {
            Console.WriteLine("Invalid input try again");
        }
    }
}