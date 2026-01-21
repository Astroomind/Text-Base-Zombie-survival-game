using System;
namespace ZombieSurvivalTextGame
{
    public class BarbarianClass
    {
        public static void ApplyBarbarian()
        {
            Program.health += 100;
            Program.armor += 10;
            Program.Attack_Dmg += 10;
            Program.accuracy += 10;
            Program.attackDmgAxeMace += 10;
        }
    }
}