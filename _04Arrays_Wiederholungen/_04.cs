// Arrays

// Ein Array ist ein Bezeichner für verschiedene Variablen/Elemente
using System.Numerics;

int[] ungeradeZahlen = { 1, 3, 5 }; // integer-Array deklariert
int ersteUngerade = ungeradeZahlen[0];
int letzteUngerade = ungeradeZahlen[2];

// Looping-Statements

double[] temperaturen = { 15.3, 16.2, 22.7, 30.0 }; // Auflistungsinitialisierer: Die Stellen werden implizit bestimmt (hier 4). Normalerweise muss man angeben,
// wieviele Stellen gebraucht werden (Arbeitsspeicherbereitstellung)

for (int i = 0; i < temperaturen.Length; i++) // i++ ist ein Inkrement, um einfach den Wert um 1 zu erhöhen
{
    Console.WriteLine("Index von " + i + ": " + temperaturen[i]);
}

// foreach-Schleife wird für jedes Element in einer Collection ausgeführt

foreach  (var item in temperaturen)
    Console.WriteLine(item);

// while-Schleife -> KOPFGESTEUERT
int index = 0;
 while  (index < temperaturen.Length)
{
    Console.WriteLine(temperaturen[index]);
    index++;
}

// do-while-Schleife -> FUßGESTEUERT
int index2 = 0;
do
{
    Console.WriteLine(temperaturen[index2]);
} while (index2 < temperaturen.Length);
