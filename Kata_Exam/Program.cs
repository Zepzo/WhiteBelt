namespace Kata_Exam;

class Program
{
    static void Main(string[] args)
    {
        var rand = new Random();
        
        int heroHealth = 80;
        int goblinHealth = 50;

        while (true)
        {
            Console.WriteLine($"Hero health: {heroHealth}");
            Console.WriteLine($"Goblin health: {goblinHealth}");
            
            Console.WriteLine();
            
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Hero attacks Goblin");
                int playerAttack = rand.Next(10, 21);
                
                Console.WriteLine($"Goblin took {playerAttack} damage");

                goblinHealth -= playerAttack;
            }
            else if (input == "2")
            {
                Console.WriteLine("Hero uses a health potion");
                int heal = rand.Next(5, 11);
                
                Console.WriteLine($"Player healed {heal}hp");

                heroHealth += heal;
            }
            else
            {
                Console.WriteLine("Please chose a valid option");
                continue;
            }
            
            Console.WriteLine();
            
            if (goblinHealth <= 0)
            {
                Console.WriteLine("Congratulations! Hero has defeated the Goblin!");
                break;
            }
            
            Console.WriteLine("Goblin attacks Hero!");
            int enemyAttack = rand.Next(10, 21);
            
            Console.WriteLine($"Hero took {enemyAttack} damage");

            heroHealth -= enemyAttack;

            if (heroHealth <= 0)
            {
                Console.WriteLine("Oh no! The Goblin defeated the Hero");
                break;
            }
        }
    }
}