namespace ZombieSurvivalTextGame
{
    public class Program //A container that holds the data such as my variables and functionality methods like Main.
    {
        public static int health = 100;
        public static int evasion_Rating = 0;
        public static int armor = 0;
        public static int Attack_Dmg = 10;
        public static int accuracy = 20;

        static void Main(string[] args) //Entry point of my C# program this is where my application start running when i press play.
        {
            Console.WriteLine("welcome adventurer!");
            Console.WriteLine("What is your name?..");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}");

            Console.WriteLine($"Please Choose your class {name}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Barbarian: \n Health - + 100. \n Damage with Maces & Axes + 10. \n Armor = + 10");
            Console.WriteLine("Rogue: \n  Evasion Rating + 50 \n Attack Damage + 25 \n Attack Damage with Dagger + 15 \n Accuracy + 30");



            Console.WriteLine($"Welcome {name}.");
            Console.WriteLine($"Your stats:\nName = {name}\nHealth = {health}\nEvasion Rating = {evasion_Rating}\nArmor = {armor}\nAttack Damage = {Attack_Dmg}\nAccuracy = {accuracy}");

            Console.WriteLine("A zombie appears!");
            Console.WriteLine("Do you attack or run? \n Please choose the following: A = Attack or R = Run.");

            string decision1 = Console.ReadLine();

            if (decision1.ToLower() == "a")
            {
                Console.WriteLine("Your probability of a successful attack depends on your accuracy rating and the enemies evasion.");
            }
            else if (decision1.ToLower() == "r")
            {
                Console.WriteLine("You chose to run away");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}