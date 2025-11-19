using cs_oop.Models;

namespace cs_oop;

// implementiamo l'incapsulamento attraverso
// il livello di accessibilità della classe e dei suoi membri
// public               accesso consentito a tutti
// protected            accesso limitato alla classe che lo contiene o ai tipi che derivano dalla classe che lo contiene
// internal             accesso limitato all'assemply (~ libreria) corrente
// protected internal	accesso limitato all'assembly (~ libreria) corrente o ai tipi che derivano dalla classe che lo contiene
// private              accesso limitato alla classe che lo contiene
// private protected	accesso limitato alla classe che lo contiene o ai tipi che derivano dalla classe che lo contiene all'interno all'assemply (~ libreria) corrente
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

// assembly: unità fondamentali di pubblicazione e riuso nelle applicazioni .NET
//           possono assumere forma di files: .exe o .dll

class Program
{
    static void Main(string[] args)
    {
        Persona gigi = new Persona("Gigi", "Bianchi");
        var mario = new Persona();
        Persona anna = new();
        mario.DataNascita = new DateTime(1980, 1, 1);
        Console.WriteLine(mario.Eta);
        mario.Nome = "Mario";
        mario.Cognome = "Rossi";

        Console.WriteLine(mario.Saluta("Ciao", "!!!"));
        Console.WriteLine(anna.Saluta("Ciao", "!!!"));
        Console.WriteLine(gigi.Saluta("Salve"));

        Console.WriteLine(Persona.CosaSono());
        var fufi = new Animale("Fufi", "Cane");

        gigi.IMieiAnimali.Add(fufi);
        gigi.IMieiAnimali.Add(new Animale("Puffo", "Gatto"));


        // esercizio Indirizzo
        // definite la classe Indirizzo (indirizzo di spedizione)


        // assegnazione veloce dei valori delle proprietà
        var indirizzo = new Indirizzo()
        {
            Via = "Via della Libertà",
            Civico = "456",
            CAP = "87987",
            Provincia = "NA",
            Citta = "Procida",
            Stato = "Italia"
        };

        Console.WriteLine(indirizzo.IndirizzoCompleto);
        Console.WriteLine(indirizzo.ToString());

        anna.Residenza = indirizzo;

    }
}





