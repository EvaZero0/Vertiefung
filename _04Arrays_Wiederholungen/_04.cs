// Arrays

// Ein Array ist ein Bezeichner für verschiedene Variablen/Elemente
using System.Numerics;

int[] ungeradeZahlen = { 1, 3, 5 }; // integer-Array deklariert
int ersteUngerade = ungeradeZahlen[0];
int letzteUngerade = ungeradeZahlen[2];

// Looping-Statements

double[] temperaturen = { 15.3, 16.2, 22.7, 30.0 };
double totalTemp = 0;
int warmeTage = 0;

for (int i = 0; i < temperaturen.Length; i++) // i++ ist ein Inkrement, um einfach den Wert um 1 zu erhöhen
{
    Console.WriteLine("Index von " + i + ": " + temperaturen[i]);
}

