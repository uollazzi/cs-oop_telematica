namespace cs_oop.Models;

public class MinorenneException : Exception
{
    public MinorenneException() : base("Utente minorenne")
    {

    }

    public MinorenneException(string message) : base(message)
    {

    }
}