using FilmekCLI;
using System.Text;

const string AdatokCSV = "D:\\PROJECTS\\CSHARP250327\\FilmekCLI\\RESOURCES\\filmekCLI_adatok.csv";

const string KeresettmufajTXT = "D:\\PROJECTS\\CSHARP250327\\FilmekCLI\\RESOURCES\\keresettmufaj.txt";

List<Film> filmek = [];

using StreamReader sr = new(AdatokCSV, Encoding.UTF8);

while (!sr.EndOfStream) filmek.Add(new(sr.ReadLine()));

Console.WriteLine("3. feladat: " +
    $"A tárhelyen {filmek.Count} film van.");

var f4 = filmek.GroupBy(f => f.Forgalmazo);
Console.WriteLine("4. feladat: gyártónként a filmek száma:");
foreach (var grp in f4)
    Console.WriteLine($"\t {grp.Key}: {grp.Count()} db");

Console.Write("5. feladat: " +
    "Adja meg egy műfaj nevét: ");
string f5 = Console.ReadLine().ToLower();
var f6 = filmek.Where(f => f.Mufaj == f5.ToLower());
using StreamWriter sw = new(KeresettmufajTXT, append: false, Encoding.UTF8);
if (!f6.Any())
    sw.WriteLine($"Nincs a tárhelyen {f5} műfajú film!");
else
{
    foreach (var film in f6)
        sw.WriteLine($"{film.Cim}\t{film.Hossz}");
}
Console.WriteLine("6. feladat: a keresettmufaj.txt elkészült!");

var f7 = filmek.MinBy(f => f.Bemutato);
if (f7 is not null)
{
    Console.WriteLine($"7. feladat: a legkorábban bemutatott film a tárhelyen:");
    Console.WriteLine(f7);
}
