namespace TechAdvocacia.Core.Exceptions;
public class ClienteAlreadyExistsException : Exception
{
    public ClienteAlreadyExistsException(): 
        base("Já existe um Cliente com esses dados.")
        {
        }
}

public class ClienteNotFoundException : Exception
{
    public ClienteNotFoundException(): 
        base("Cliente não encontrado.")
        {
        }
}
