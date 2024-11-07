decimal zahl1, zahl2, ergebnis;
string operation;

Console.WriteLine("Calculator\n" +
    "Anleitung:\n" +
    "Um eine Rechnung durchzuführen, geben Sie zwei Zahlen ein und bestätigen Sie jeweils mit Enter.\n" +
    "Wählen Sie die Rechenart und bestätigen Sie mit Enter." +
    "Drücken Sie Q, um das Programm zu beenden.");

do
{
    Console.WriteLine("Zahl 1:");
    zahl1 = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Zahl 2:");
    zahl2 = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Rechenart: Addieren (A oder +), Subtrahieren (S oder -), Multiplizieren (M oder *), Dividieren (D oder /), Beenden (Q)");
    operation = Console.ReadLine().ToUpper();
    switch (operation)
    {
        case ("A" or "+"):
            ergebnis = zahl1 + zahl2;
            Console.WriteLine($"{zahl1} + {zahl2} = {ergebnis}");
            break;
        case ("S" or "-"):
            ergebnis = zahl1 - zahl2;
            Console.WriteLine($"{zahl1} - {zahl2} = {ergebnis}");
            break;
        case ("M" or "*"):
            ergebnis = zahl1 * zahl2;
            Console.WriteLine($"{zahl1} * {zahl2} = {ergebnis}");
                        break;
            case ("D" or  "/"):
            if (zahl2 == 0)
            {
                Console.WriteLine("Division durch 0 ist nicht erlaubt.");
                break;
            }
            ergebnis= zahl1 / zahl2;
            Console.WriteLine($"{zahl1} / {zahl2} = {ergebnis}");

            break;
        case ("Q"):
            break;
    }
    Console.WriteLine("[Q] zum Beenden oder sonstiges drücken, zum Fortfahren.");
    var userChoice = Console.ReadLine().ToUpper();
    if (userChoice == "Q")
        break;
    
} while (true);
