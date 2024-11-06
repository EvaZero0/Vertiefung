
// Verzweigungslogik: if-else-Statement oder switch-Statement

decimal gewinn = 2.5M;  // decimal ist genauer als double, aber benöigt mehr Arbeitsspeicher; entweder man verwendet ein M-Suffix oder castet
// der Wert könnte aber auch vom User eingegeben werden

string aktion = "";
bool istGewinnKlein = (gewinn <= 2m); // true (1) oder false (0); <= ist ein Vergleichsoperator

if (istGewinnKlein) //Bedingung;, false wäre (!istGewinnKlein)
{
    aktion = "Verkaufe";
}
else if (gewinn > 2m && gewinn <= 4m)
{
    aktion = "Abwarten";
}
else // Standardfall
{
    aktion = "Verkaufe";
}

// switch-Statements (wenn die Fälle durch konstante Werte, z.B. integer oder strings, bestimmt sind)

string aktuellesWetter = "Regen";
string ausruestung = "";

switch (aktuellesWetter) //Selektor
{
    case "Regen":
        ausruestung = "Regenschirm";
        break;

    case "Sonne":
        ausruestung = "Sonnencreme";
        break;

    case "Kalt": // wenn ein leerer Fall definiert wird, benötigt man keinen break, es wird direkt zum nächsten case gesprungen 
                 //Vermeidung von Redundanz
    case "Neblig":
        ausruestung = "Jacke";
        break;

    default:
        ausruestung = "Ersatzsocken";
        break;
}