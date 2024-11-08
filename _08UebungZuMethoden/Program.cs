double[] temperaturen = [15.3, 16.2, 22.7, 30.0];

double durchschnittTemp = BerechneTempAvg(temperaturen);
int anzahlWarmeTage = ZähleWarmeTage(temperaturen);

Console.WriteLine($"Durchschnittstemperatur: {durchschnittTemp} °C " +
    $"\nTage über 20 Grad: {anzahlWarmeTage}");

double BerechneTempAvg(double[] tempArray)
{
    double summeTemp = 0;
    for (int i = 0; i < temperaturen.Length; i++)
    {
        summeTemp += temperaturen[i];
    }
    double tempAvg = Math.Round(summeTemp / temperaturen.Length, 2);
    return tempAvg;
}

int ZähleWarmeTage(double[] temperaturen)
{
    int warmeTage = 0;
    for (int i = 0; i < temperaturen.Length; i++)
    {
        if (temperaturen[i] > 20)
            warmeTage++;
    }
    return warmeTage;
}

