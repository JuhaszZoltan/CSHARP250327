namespace FilmekCLI;

class Film
{
    public string Cim { get; set; }
    public int Bemutato { get; set; }
    public string Mufaj { get; set; }
    public string Forgalmazo { get; set; }
    public int Hossz { get; set; }

    public override string ToString() =>
        $"\t Cím: {Cim}\n" +
        $"\t Bemutató éve: {Bemutato}\n" +
        $"\t Műfaj: {Mufaj}\n" +
        $"\t Gyártó/Forgamazó: {Forgalmazo}\n" +
        $"\t Hossza: {Hossz} perc";

    public Film(string beolvasottSor)
    {
        var tmp = beolvasottSor.Split(';');

        Cim = tmp[0];
        Bemutato = int.Parse(tmp[1]);
        Mufaj = tmp[2];
        Forgalmazo = tmp[3];
        Hossz = int.Parse(tmp[4]);
    }
}
