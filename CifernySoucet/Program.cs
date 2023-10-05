//druhák gg

Console.WriteLine("Zadej 1. fialová / 2. zelená");
Console.WriteLine("zadávej pouze čísla c:");
string barva = Console.ReadLine();
if (barva == "1")
{
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
}
else if (barva == "2")
{
    Console.BackgroundColor = ConsoleColor.Green;
}

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("UKONČÍŠ TO ČÍSLEM 69 !!!!!!!!");


while (true)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Zadej číslo pls uwu c:");

    string Cislo; //tohle je deklarace ==(neboli) vytvoření místa v paměti 
    Cislo = Console.ReadLine();  //Co zadá nějakej random člověk
    if (Cislo == "69")
    {
        break;
    }

    int vysledek = 0;

    foreach (char jednaCifra in Cislo)
    {
        string stringCifraa = jednaCifra.ToString();//zde se to převád ín na string 
        int hodnotaCifry = Convert.ToInt32(stringCifraa);

        vysledek += hodnotaCifry;
    }
    Console.WriteLine("tvůj výsledek je: "+ vysledek);
    Console.WriteLine("gg");

    Thread.Sleep(3000);
    Console.Clear();
    
}