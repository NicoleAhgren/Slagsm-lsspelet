using System;

string Namn1 = "";
string Namn2 = "";

int BubbelHp = 100;
int MolnHp = 100;

Random generator = new Random();

Console.WriteLine("Välj namnet på karaktär nummer 1 och tryck ENTER");
Namn1 = Console.ReadLine();
Console.WriteLine("Välj namnet på karaktär nummer 2 och tryck ENTER");
Namn2 = Console.ReadLine();

while (BubbelHp > 0 && MolnHp > 0)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("\n~~ Ny Runda ~~");
    Console.ResetColor();

    Console.WriteLine(" ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{Namn1}: {BubbelHp}Hp {Namn2}: {MolnHp}Hp\n");
    Console.ResetColor();

    int BubbelSkada = generator.Next(35);
    MolnHp -= BubbelSkada;
    MolnHp = Math.Max(0, MolnHp);

    Console.WriteLine($"{Namn1} blåser sprängbubblor så att {Namn2} förlorar {BubbelSkada} Hp");

    int MolnSkada = generator.Next(35);
    BubbelHp -= MolnSkada;
    BubbelHp = Math.Max(0, BubbelHp);

    Console.WriteLine($"{Namn2} skapar blixtmoln så att {Namn1} förlorar {MolnSkada} Hp");

    Console.WriteLine("Tryck ENTER för att fortsätta");
    Console.ReadKey();
}

Console.WriteLine(" ");

Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("~~ Fighten är över ~~");
Console.ResetColor();

Console.WriteLine(" ");

if (MolnHp == 0)
{
    Console.WriteLine("Bubbelmannen vann med hjälp av sina sprängbubblor!");
}
else if (BubbelHp == 0)
{
    Console.WriteLine("Molnmannen vann med hjälp av sina blixtrande moln!");
}
else if (BubbelHp == 0 && MolnHp == 0)
{
    Console.WriteLine("Båda dog samtidigt. Det blev oavgjort!");
}

Console.WriteLine("Tryck på ENTER för att avsluta");
Console.ReadKey();