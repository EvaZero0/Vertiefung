// Die beiden Funktionen HoleErsteZahl und HoleZweiteZahl lassen sich
// logisch zusammenfassen (Vermeidung von Coderedundanz)

double ersteZahl = HoleZahl("erste Zahl:");

double zweiteZahl = HoleZahl("zweite Zahl: ");

double ergebnis = Addiere(ersteZahl, zweiteZahl);

DruckeErgebnis(ergebnis);

double HoleZahl(string welcheZahl)       // generische Vorgehensweise
{                                         // wichtig für Wiederverwendbarkeit
    Console.WriteLine(welcheZahl);
    string eingabe = Console.ReadLine();
    return double.Parse(eingabe);
}

//double HoleErsteZahl()             
//{
//    Console.WriteLine("erste Zahl: ");
//    string ersteZahlEingabe = Console.ReadLine();
//    return double.Parse(ersteZahlEingabe);         

//}

//double HoleZweiteZahl()
//{
//    Console.WriteLine("zweite Zahl: ");
//    string zweiteZahlEingabe = Console.ReadLine();
//    return double.Parse(zweiteZahlEingabe);
//}

double Addiere(double ersteZahl, double zweiteZahl)    
{
    return ersteZahl + zweiteZahl;      
}

void DruckeErgebnis(double ergebnis)
{
    Console.WriteLine($"Das Ergebnis ist {ergebnis}.");
}