namespace cs_oop.Models;

public class Persona
{
    // proprietà
    public string? Nome { get; set; }

    private string cognome = string.Empty; // ""
    public string Cognome
    {
        get
        {
            return cognome;
        }
        set
        {
            cognome = value;
        }
    }

    public double Peso { get; set; }

    // con valore di default
    public string Soprannome { get; set; } = string.Empty;

    // readonly
    public int Id { get; private set; }

    // validazione
    private DateTime? dataNascita = null;
    public DateTime DataNascita
    {
        get
        {
            return dataNascita ?? DateTime.Now;
        }
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Data non valida. Non è ancora nato");

            dataNascita = value;
        }
    }

    // proprietà calcolate
    public string NomeCompleto
    {
        get
        {
            return $"{Nome} {Cognome}";
        }
    }

    public int Eta { get => (int)Math.Floor(DateTime.Now.Subtract(DataNascita).TotalDays / 365); }

    // metodi
    // sono funzioni
    public string Saluta(string tipoSaluto, string punteggiatura)
    {
        return $"{tipoSaluto}, sono {NomeCompleto} e ho {Eta} anni{punteggiatura}";
    }

    // overload
    public string Saluta(string tipoSaluto)
    {
        return Saluta(tipoSaluto, ".");
    }

    // costruttore
    // metodo che viene automaticamente eseguito
    // nel momento in cui istanziamo un oggetto
    public Persona()
    {

    }

    public Persona(string nome, string cognome)
    {
        this.Nome = nome;
        this.Cognome = cognome;
    }

    // membri (metodi+proprietà) statici (di classe)
    public static string CosaSono()
    {
        return "Sono una persona";
    }

    public List<Animale> IMieiAnimali { get; set; } = [];
}