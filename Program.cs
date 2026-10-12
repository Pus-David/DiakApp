using DiakApp;

List<Diak> diakok = new List<Diak>();
int hibasSorokSzama = 0;
foreach (var sor in File.ReadAllLines("eredmenyek.csv"))
{
    string[] adatok = sor.Split(';');
    if (adatok.Length != 3)
    {
        hibasSorokSzama++;
        continue;
    }
    string nev = adatok[0].Trim();
    string osztaly = adatok[1].Trim();
    if (!int.TryParse(adatok[2], out int pontszam))
    {
        hibasSorokSzama++;
        continue;
    }
    if( string.IsNullOrWhiteSpace(nev)|| String.IsNullOrWhiteSpace(osztaly))
    {
        hibasSorokSzama++;
        continue;
    }
    diakok.Add(new Diak(nev, osztaly, pontszam));
}

Console.WriteLine($"Sikeresen beolvasott diakok szama: {diakok.Count}");
Console.WriteLine($"hibas sorok szama: { hibasSorokSzama}");
foreach (Diak kiir in diakok)
{
    Console.WriteLine(kiir);
}