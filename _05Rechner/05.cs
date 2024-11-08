
bool programmLaueft = true;

do
{
    Console.WriteLine("Wähle Operation: Addition [A], Subtraktion [S], Multiplikation [M], Division [D], Beenden [Q]");
        string eingabe = Console.ReadLine().ToUpper();
    char erstesZeichen = eingabe[0];
    double zahl1 = 0, zahl2 = 0, ergebnis = 0;
    string ausgabe = "";
   

    if (programmLaueft)
    {
        Console.WriteLine("Erste Zahl:");
        zahl1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Zweite Zahl:");
        zahl2 = double.Parse(Console.ReadLine());
    }
    switch (erstesZeichen)
    {
        case 'B' or 'Q':
            programmLaueft = false;
            break;
        case 'A' or '+':
            ergebnis = zahl1 + zahl2;
            ausgabe = $"{zahl1} + {zahl2} = {ergebnis}";
            break;
    }
    programmLaueft = false;
} while (programmLaueft);
