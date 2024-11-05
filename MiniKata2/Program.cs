namespace MiniKata2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Zätha";
        int health = 100;
        float attackPower = 15.5f;
        bool isParalised = true;
        double amount = 24.75;

        double doubbleHealth = Convert.ToDouble(health);
        int intAttackPower = Convert.ToInt32(attackPower);
        int intAount = Convert.ToInt32(amount);
        double value = double.Parse("150,333");
        
        Console.WriteLine(doubbleHealth);
        Console.WriteLine(intAttackPower);
        Console.WriteLine(intAount);
        Console.WriteLine(value);
        
       if (int.TryParse(name, out int result)) 
       { 
           Console.WriteLine(result);
       }
    }
}