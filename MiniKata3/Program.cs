namespace MiniKata3;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        int luckValue = random.Next(1, 11);
        
        Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
        string awnser = Console.ReadLine();

        if (awnser.ToLower() == "yes")
        {
            Console.WriteLine("Attempting to attack...");
            if (luckValue > 7)
            {
                Console.WriteLine("Success! Your attack hits the enemy.");
            }
            else if (luckValue == 6 || luckValue == 7)
            {
                Console.WriteLine("Success! Your attack barley hits the enemy.");
            }
            else
            {
                Console.WriteLine("Your attack missed the enemy");
            }
        }
        else
        {
            Console.WriteLine("You ran away");
        }
    }
}