namespace cs_oop.Models;

public class Indirizzo
{
    public string Via { get; set; } = string.Empty;

    public string Civico { get; set; } = string.Empty;

    public string CAP { get; set; } = string.Empty;

    public string Citta { get; set; } = string.Empty;

    public string Provincia { get; set; } = string.Empty;

    public string Stato { get; set; } = string.Empty;

    public string IndirizzoCompleto { get => $"{Via}, {Civico}\n{CAP} {Citta} ({Provincia})\n{Stato}"; }
}