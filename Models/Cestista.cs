namespace cs_oop.Models;

public class Cestista : Persona
{
    public Cestista()
    {
        Console.WriteLine("Cestista creato");
    }

    public string Squadra { get; set; } = string.Empty;

    public int Numero { get; set; }

    public bool Tira()
    {
        return true;
    }

    public Cestista(string nome, string cognome, string squadra, int numero)
        : base(nome, cognome)
    {
        Squadra = squadra;
        Numero = numero;
    }

    public override string Saluta(string tipoSaluto, string punteggiatura)
    {
        var saluto = base.Saluta(tipoSaluto, punteggiatura);
        saluto += $"\nGioco nei {Squadra} col numero {Numero}";

        return saluto;
    }
}