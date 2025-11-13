namespace cs_oop.Models;

public class Animale
{
    public string Nome { get; set; }
    public string Razza { get; set; }

    public Animale(string nome, string razza)
    {
        Nome = nome;
        Razza = razza;
    }
}