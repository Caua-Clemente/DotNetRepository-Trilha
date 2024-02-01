namespace projMid.WebApp.Middlewares;
public class PortasMiddleware
{
    private readonly RequestDelegate _next;
    public PortasMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Add Portas --> ");
        await _next .Invoke(context);
    }
}

public static class PortasMiddlewareExtensions
{
    public static IApplicationBuilder UsePortasMiddleWare(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<PortasMiddleware>();
    }
}