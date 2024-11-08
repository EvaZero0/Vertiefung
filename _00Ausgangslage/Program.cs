// diese Programm funktioniert, ist aber nicht sehr gut lesbar (abgesehen von den Bezeichnern

Console.WriteLine("erste Zahl: ");
string ersteZahlEingabe = Console.ReadLine();
double ersteZahl = double.Parse(ersteZahlEingabe);
Console.WriteLine("zweite Zahl: ");
string zweiteZahlEingabe = Console.ReadLine();
double zweiteZahl = double.Parse(zweiteZahlEingabe);
double ergebnis = ersteZahl + zweiteZahl;
Console.WriteLine($"Das Ergebnis ist {ergebnis}.");

// was könnte helfen?
// - Code kommentieren - Nachteil: zu viele Kommentare, Kommentar kann obsolet werden

// - Refaktorierung/Refactoring!
// Hierbei wird der Code umgestaltet, ohne die Funktionalität zu verändern.
// So soll der Code lesbarer werden!