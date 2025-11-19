namespace cs_oop.Interfaces;

public interface ITrasferibile
{
    void TrasferiscimiA(string nuovaSquadra);

    DateTime? DataUltimoTrasferimento { get; }
}