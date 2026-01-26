using System;

namespace ZombieSurvivalTextGame
{
    public class Program //A container that holds the data such as my variables and functionality methods like Main.
    {
        public static int health = 100;
        public static int evasion_Rating = 0;
        public static int armor = 0;
        public static int Attack_Dmg = 10;
        public static int accuracy = 20;
        public static int attackDmgAxeMace = 0;
        public static int attackDmgDagger = 0;

        static void Main(string[] args) //Entry point of my C# program this is where my application start running when i press play.
        {
            Console.WriteLine("welcome adventurer!");
            Console.WriteLine("What is your name?..");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}");

            Console.WriteLine($"Please Choose your class (Enter the character in brackets to choose your class)");
            Console.WriteLine("For example: if you chose Barbarian then you simply input the letter b");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Barbarian: (b) \n Health - + 100. \n Damage with Maces & Axes + 10. \n Armor = + 10");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Rogue: (r)\n  Evasion Rating + 50 \n Attack Damage + 25 \n Attack Damage with Dagger + 15 \n Accuracy + 30");
            Console.WriteLine("-----------------------------");

            string classChoice = Console.ReadLine();

            if (classChoice.ToLower() == "b")
            {
                BarbarianClass.ApplyBarbarian();
                Console.WriteLine("You have chosen the Barbarian!");
            }
            else if (classChoice.ToLower() == "r")
            {
                RogueClass.ApplyRogue();
                Console.WriteLine("You have chosen the Rogue");
            }

            Console.WriteLine($"Your stats:\n Health = {health}\n Evasion Rating = {evasion_Rating}\n Armor = {armor}\n Attack Damage = {Attack_Dmg}\n Accuracy = {accuracy}\n Attack Damage with Mace & Axe = {attackDmgAxeMace}");
        }
    }
}