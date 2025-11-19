using cs_oop.Interfaces;
using cs_oop.Models;

namespace cs_oop;

class Program
{
    static void Main(string[] args)
    {
        var gigi = new Persona("Gigi", "Rossi");
        var kd = new Cestista("Kevin", "Durant", "Brooklin", 7);
        Console.WriteLine(kd.Saluta("Ciao"));

        Trasferisci(kd, "Bulls");

        Console.WriteLine(kd.Saluta("Ciao"));

        List<string> l1 = ["cane", "gatto"];
        string[] l2 = ["mela", "pera"];

        StampaLista(l1);
        StampaLista(l2);
    }

    static void Trasferisci(ITrasferibile persona, string squadra)
    {
        persona.TrasferiscimiA(squadra);
    }

    static void StampaLista(IEnumerable<string> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}





