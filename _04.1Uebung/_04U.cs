double[] temperaturen = [15.3, 16.2, 22.7, 30.0];
double summeTemp = 0;
int warmeTage = 0;

// Aufgabe: Was ist die Durchschnittstemperatur? Wieviele Tage mit Temperaturen über 20 Grad?
for (int i = 0; i < temperaturen.Length; i++)
{
    summeTemp += temperaturen[i];

    if (temperaturen[i] > 20)
        warmeTage++;
}
var durchschnittTemp = Math.Round(summeTemp / temperaturen.Length, 2);

Console.WriteLine($"Durchschnittstemperatur: {durchschnittTemp} °C " +
    $"\nTage über 20 Grad: {warmeTage}");














// Durchschnittswert eines Arrays -> temperaturen.Average()

// Erstelle ein Array für Bestellpostenpreise: errechne die Gesamtsumme, ermittle den höchsten/niedrigsten Preis UND den Durchschnitt

decimal[] bestPostenPreis = [19.99m, 2.37m, 114.89m, 33.33m, 25.00m];
decimal gesamtPreis = 0;
decimal maxPreis = bestPostenPreis[0];
decimal minPreis = bestPostenPreis[0];

for (int i = 0; i < bestPostenPreis.Length; i++)
{
    gesamtPreis += bestPostenPreis[i];

    if (bestPostenPreis[i] > maxPreis)
        maxPreis = bestPostenPreis[i];
    else if (bestPostenPreis[i] < minPreis)
        minPreis = bestPostenPreis[i];
}
decimal durchschnittPreis = Math.Round(gesamtPreis / bestPostenPreis.Length, 2);

Console.WriteLine($"Gesamtpreis: {gesamtPreis} $" +
    $"\nHöchster Preis: {maxPreis} $" +
    $"\nNiedrigster Preis: {minPreis} $" +
    $"\nDurchschnittspreis: {durchschnittPreis} $");