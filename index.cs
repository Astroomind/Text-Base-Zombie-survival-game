Console.WriteLine("welcome to my Zombie game bruh");
Console.WriteLine("What is your name?");

string name = Console.ReadLine();
int health = 100;
double hunger = 75.5;

Console.WriteLine($"Welcome {name}.");
Console.WriteLine($"Your stats: Name - {name} Health - {health} Hunger - {hunger}");

Console.WriteLine("A zombie appears!");
Console.WriteLine("Do you attack or run? \n Please choose the following: A = Attack or R = Run.");

string decision1 = Console.ReadLine();
