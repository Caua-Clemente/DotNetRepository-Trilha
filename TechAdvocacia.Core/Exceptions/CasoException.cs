namespace TechAdvocacia.Core.Exceptions;
public class CasoNotFoundException : Exception
{
    public CasoNotFoundException(): 
        base("Caso não encontrado.")
        {
        }
}
