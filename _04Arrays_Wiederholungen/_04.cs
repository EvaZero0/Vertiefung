// Arrays

// Ein Array ist ein Bezeichner für verschiedene Variablen/Elemente
using System.Numerics;

int[] ungeradeZahlen = { 1, 3, 5 }; // integer-Array deklariert
int ersteUngerade = ungeradeZahlen[0];
int letzteUngerade = ungeradeZahlen[2];

// Looping-Statements

//double[] temperaturen = { 15.3, 16.2, 22.7, 30.0 };

//for (int i = 0; i < temperaturen.Length; i++) // i++ ist ein Inkrement, um einfach den Wert um 1 zu erhöhen
//{
//    Console.WriteLine(temperaturen[i]);
//}

double[] temperaturen = { 15.3, 16.2, 22.7, 30.0 };
double totalTemp = 0;
int warmeTage = 0;

for (int i = 0; i < temperaturen.Length; i++)
{
    Console.WriteLine("Index von " + i + ": " + temperaturen[i]);
}

// Aufgabe: Was ist die Durchschnittstemperatur? Wieviele Tage mit Temperaturen über 20 Grad?
for (int i = 0; i < temperaturen.Length; i++)
{
    totalTemp += temperaturen[i];

    if (temperaturen[i] > 20)
        warmeTage++;
}
Console.WriteLine("Durchschnittstemperatur: " + totalTemp / temperaturen.Length + "\nTage über 20 Grad: " + warmeTage);
// Erstelle ein Array für Bestellpostenpreise: errechne die Gesamtsumme, ermittle den höchsten/niedrigsten Preis UND den Durchschnitt

decimal[] bPostenPreis = { 19.99m, 2.37m, 114.89m, 33.33m, 25.00m };
decimal gesamtPreis = 0;
decimal maxPreis = bPostenPreis[0];
decimal minPreis = bPostenPreis[0];

for (int i = 0; i < bPostenPreis.Length; i++)
{
    gesamtPreis += bPostenPreis[i];

    if (bPostenPreis[i] > maxPreis)
        maxPreis = bPostenPreis[i];
    else if (bPostenPreis[i] < minPreis)
        minPreis = bPostenPreis[i];
}
decimal durchschnittPreis = Math.Round(gesamtPreis / bPostenPreis.Length, 2);

Console.WriteLine($"Gesamtpreis: {gesamtPreis}" +
    $"\nHöchster Preis: {maxPreis}" +
    $"\nNiedrigster Preis: {minPreis}" +
    $"\nDurchschnittspreis: {durchschnittPreis}");