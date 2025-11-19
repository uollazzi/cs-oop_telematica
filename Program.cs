using cs_oop.Models;

namespace cs_oop;

class Program
{
    static void Main(string[] args)
    {
        var lebron = new Cestista()
        {
            Nome = "Lebron",
            Cognome = "James",
            DataNascita = new DateTime(1984, 12, 30),
            Squadra = "L.A. Lakers",
            Numero = 23
        };

        Console.WriteLine(lebron.Saluta("Ciao"));

        var kd = new Cestista("Kevin", "Durant", "Brooklin Nets", 7);

        var me = new MinorenneException("Poppante");
        Console.WriteLine(me.Message);

        var nicola = new Persona("Nicola", "Gialli");
        nicola.DataNascita = new DateTime(2020, 10, 10);

        try
        {
            if (nicola.Eta < 18)
                throw new MinorenneException($"Minorenne in quanto ha {nicola.Eta} anni");
        }
        catch (MinorenneException ex)
        {
            Console.WriteLine(ex.GetType());
            Console.WriteLine(ex.Message);
        }

        Registra(nicola);
        Registra(lebron);
    }

    static void Registra(Persona persona)
    {
        Console.WriteLine("Persona registrata correttamente");
        Console.WriteLine(persona.GetType());
        Console.WriteLine(persona.Saluta("Ciao", "!"));
    }
}





