using System.Globalization;
using cs_oop.Interfaces;
using cs_oop.Models;
using CsvHelper;

namespace cs_oop;

class Program
{
    static void Main(string[] args)
    {
        using var reader = new StreamReader("persone.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        var persone = csv.GetRecords<Persona>().ToList();

        foreach (var p in persone)
        {
            Console.WriteLine(p);
        }

    }
}