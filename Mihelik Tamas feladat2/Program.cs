using ClassLibrary1.Data;
using ClassLibrary1.Models;

static void Kiir(IEnumerable<object> adatok)
{
    foreach (var adat in adatok)
    {
        Console.WriteLine(adat.ToString());
    }
    Console.WriteLine();
}

MyContext db = new();
if (!db.People.Any())
{
    var sorok = File.ReadAllLines(@"C:\Users\Diak\dev\mt\cs\Mihelik Tamás Doga\20.csv").Skip(1);
    int key = 0;
    foreach (var sor in sorok)
    {
        db.People.Add(new CSVclass($"{key};"+sor));
        key += 1;
    }
    db.SaveChanges();
}

Kiir(db.People);