using System.Text;

namespace Modulo4.LinhaDeMontagem;

public class ExecutionTimeMiddleware
{
    private readonly RequestDelegate _next;
    public ExecutionTimeMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        DateTime startTime = DateTime.Now;

        context.Response.ContentType = "text/html; charset=utf-8";
        await _next(context);

        DateTime endTime = DateTime.Now;
        TimeSpan executionTime = endTime - startTime;
        string tempo = executionTime.Microseconds.ToString();
        descricao.AdicionarEtapa("Tempo de Execução", $"{tempo} microssegundos");

        await context.Response.WriteAsync(descricao.ToString());
    }
} 

public class CustomHeaderMiddleware
{
    private readonly RequestDelegate _next;
    public CustomHeaderMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        DateTime dataHoraAtual = DateTime.Now;
        string horario = dataHoraAtual.ToString("HH:mm:ss");
        
        string ipAddress = context.Connection.RemoteIpAddress?.ToString();

        context.Response.ContentType = "text/html; charset=utf-8";
        descricao.AdicionarEtapa("Horário da requisição", horario);
        descricao.AdicionarEtapa("IP", ipAddress);

        await _next(context);
        //await context.Response.WriteAsync(descricao.ToString());
    }
} 


public class AddChassiMiddleware
{
    private readonly RequestDelegate _next;
    public AddChassiMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        descricao.AdicionarEtapa("Chassi", "Chassi adicionado");
        await _next(context);
        //await context.Response.WriteAsync(descricao.ToString());
    }
} 

public class AddMotorMiddleware
{
    private readonly RequestDelegate _next;
    public AddMotorMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        descricao.AdicionarEtapa("Motor", "Motor adicionado");
        await _next(context);
    }
}

public class AddPortasMiddleware
{
    private readonly RequestDelegate _next;
    public AddPortasMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        descricao.AdicionarEtapa("Portas", "Portas adicionadas");
        await _next(context);
        descricao.AdicionarEtapa("Portas", $"Maçanetas {descricao.Cor} adicionadas");
    }

}

public class AddPinturaMiddleware
{
    private readonly RequestDelegate _next;
    public AddPinturaMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        var cores = new string[] { "Preto", "Branco", "Vermelho", "Azul" };
        descricao.Cor = cores[new Random().Next(0, cores.Length)];
        descricao.AdicionarEtapa("Pintura", $"Pintura adicionada na cor {descricao.Cor}");
        await _next(context);
    }
}
public class AddInternoMiddleware
{
    private readonly RequestDelegate _next;
    public AddInternoMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        descricao.AdicionarEtapa("Acabamento Interno", $"Acabamento Interno adicionado na cor {descricao.Cor}");
        if (!context.Response.HasStarted)
            await _next(context);
    }
}

public class LinhaDeMontagemDescricao
{
    public List <(string,string)> descricao = new List<(string,string)>();
    public string Cor { get; set; }
    public void AdicionarEtapa(string etapa, string descricao)
    {
        this.descricao.Add((etapa, descricao));
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        int i = 1;
        foreach (var item in descricao)
        {
            sb.AppendLine($"Etapa {i++}: {item.Item1} - {item.Item2}<br>");
        }
        return sb.ToString();
    }
}
