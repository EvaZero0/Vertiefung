
// C# ist stark typisiert (strongly typed), es muss klar sein, mit welchem Typ ich es zu tun habe
// Der Compiler erlaubt keine impliziten Konvertierungen zwischen inkompatiblen Typen
//int gesamtsumme = "300"; // Fehler, da "300" ein string-literal ist...
//string nachricht = 7;   // das geht so auch nicht...

// ABER es gibt Möglichkeiten, Konvertierungen explizit (ausdrücklich) auszuführen
int total = int.Parse("300");
string wochentag = 4.ToString();

// Cast-Operator wenn Typen grundsätzlich kompatibel sind
double praeziseLaenge = 5.21;
int abgeschnitteneLaenge = (int)praeziseLaenge; //Compiler akzeptiert die Verwandlung
int gerundeteLaenge = (int)Math.Round(praeziseLaenge, 0);

// A einschränkende Konvertierung (von groß nach klein)
long groß = 34;
short klein = (short)groß;

// B erweiternde Konvertierung (implizite Konvertierung)
groß = klein;
praeziseLaenge = abgeschnitteneLaenge;