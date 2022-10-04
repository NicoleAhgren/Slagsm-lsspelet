using System;

string Namn1 = "";
string Namn2 = "";

int k1Hp = 100;
int k2Hp = 100;

Random generator = new Random();

Console.WriteLine("Välj namnet på karaktär nummer 1 och tryck ENTER");
Namn1 = Console.ReadLine();

Console.WriteLine("Välj namnet på karaktär nummer 2 och tryck ENTER");
Namn2 = Console.ReadLine();

while (k1Hp > 0 && k2Hp > 0)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("\n~~ Ny Runda ~~");
    Console.ResetColor();

    Console.WriteLine(" ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{Namn1}: {k1Hp}Hp {Namn2}: {k2Hp}Hp\n");
    Console.ResetColor();

    int Namn1Skada = generator.Next(36);
    k2Hp -= Namn1Skada;
    k2Hp = Math.Max(0, k2Hp);

    Console.WriteLine($"{Namn1} Sparkar så att {Namn2} förlorar {Namn1Skada} Hp");

    int Namn2Skada = generator.Next(36);
    k1Hp -= Namn2Skada;
    k1Hp = Math.Max(0, k1Hp);

    Console.WriteLine($"{Namn2} skapar blixtmoln så att {Namn1} förlorar {Namn2Skada} Hp");

    Console.WriteLine("Tryck ENTER för att fortsätta");
    Console.ReadKey();
}

Console.WriteLine(" ");

Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("~~ Fighten är över ~~");
Console.ResetColor();

Console.WriteLine(" ");

if (k2Hp == 0)
{
    Console.WriteLine($"{Namn1} vann med hjälp av sina sprängbubblor!");
}
else if (k1Hp == 0)
{
    Console.WriteLine($"{Namn2} vann med hjälp av sina blixtrande moln!");
}
else if (k1Hp == 0 && k2Hp == 0)
{
    Console.WriteLine("Båda dog samtidigt. Det blev oavgjort!");
}

Console.WriteLine("Tryck på ENTER för att avsluta");
Console.ReadKey();


