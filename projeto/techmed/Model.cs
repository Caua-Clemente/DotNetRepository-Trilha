using Microsoft.EntityFrameworkCore;

namespace Techmed.Model;
public class TechmedContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        base.OnConfiguring(optionsBuilder);
        var stringConexao = "server=localhost;user=dotnet;password=tic2023;database=techmed";
        var serverVersion = ServerVersion.AutoDetect(stringConexao);
        optionsBuilder.UseMySql(stringConexao, serverVersion);
    }
}

public abstract class Pessoa{
    public int ID { get; set; }
    public string Nome { get; set; }
}

public abstract class Paciente : Pessoa{
    public string Telefone { get; set; }
}

public abstract class Medico : Pessoa{
    public string Especialidade { get; set; }
    public float Salario { get; set; }
}