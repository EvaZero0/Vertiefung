// In der OOP werden Funktionen METHODEN genannt.
// Durch die Methoden spricht der Code für sich selbst
double ersteZahl = HoleErsteZahl();

double zweiteZahl = HoleZweiteZahl();

double ergebnis = Addiere(ersteZahl, zweiteZahl);

DruckeErgebnis(ergebnis);

// Hier bauen wir Methoden:

double HoleErsteZahl()              // Die Methode hat einen Rückgabewert (double) und fängt mit einem Großbuchstaben an
{
    Console.WriteLine("erste Zahl: ");
    string ersteZahlEingabe = Console.ReadLine();
    return double.Parse(ersteZahlEingabe);          // zurückgegeben wird die eingegebene Zahl
               
}

double HoleZweiteZahl()
{
    Console.WriteLine("zweite Zahl: ");
    string zweiteZahlEingabe = Console.ReadLine();
    return double.Parse(zweiteZahlEingabe) ;
}

double Addiere(double ersteZahl, double zweiteZahl)     // hier hat die Methode Parameter, also Werte, die von außen kommen
{
    return ersteZahl + zweiteZahl;      // Verarbeitung und Rückgabe
}

void DruckeErgebnis(double ergebnis)
{
    Console.WriteLine($"Das Ergebnis ist {ergebnis}.");
}