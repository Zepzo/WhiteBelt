namespace Kata1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, brave adventurer! What is your name?");
        String name = Console.ReadLine();
        Console.WriteLine($"Greetings, {name}! Your journey begins now...");
        
        Console.WriteLine("On a scale of 1 to 10, how excited are you to start this quest?");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 5)
        {
            Console.WriteLine("You dont seem too exited for this adbenture");
        }
        else
        {
            Console.WriteLine("Fantastic! You seem ready to take on any challenge!");
        }
    }
}