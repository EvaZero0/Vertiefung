decimal[] bestPostenPreis = [19.99m, 2.37m, 114.89m, 33.33m, 25.00m];
decimal gesamtPreis = BerechneGesamt(bestPostenPreis);
decimal maxPreis = ErmittleMax(bestPostenPreis);
decimal minPreis = ErmittleMin(bestPostenPreis);
decimal avgPreis = BerechneAvg(bestPostenPreis);

Console.WriteLine($"Gesamtpreis: {gesamtPreis} $" +
    $"\nHöchster Preis: {maxPreis} $" +
    $"\nNiedrigster Preis: {minPreis} $" +
    $"\nDurchschnittspreis: {avgPreis} $");
decimal BerechneGesamt(decimal[] preise)
{
    decimal gesamt = preise[0];
    for (int i = 1; i < preise.Length; i++)
    {
        gesamt += preise[i];
    }
    return gesamt;
}
decimal ErmittleMax(decimal[] preise)
{
    decimal max = preise[0];
    for (int i = 1; i < preise.Length; i++)
    {
        if (preise[i] > max)
            max = preise[i];
    }
    return max;
}
decimal ErmittleMin(decimal[] preise)
{
    decimal min = preise[0];
    for (int i = 1; i < preise.Length; i++)
    {
        if (preise[i] < min)
            min = preise[i];
    }
    return min;
}
decimal BerechneAvg(decimal[] preise)
{
    decimal durchschnitt = Math.Round(gesamtPreis / bestPostenPreis.Length, 2);
    return durchschnitt;
}