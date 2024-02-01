namespace projMid.WebApp.Middlewares;
public class ChassiMiddleware
{
    private readonly RequestDelegate _next;
    public ChassiMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Add Chassi --> ");
        await _next .Invoke(context);
    }
}

public static class ChassiMiddlewareExtensions
{
    public static IApplicationBuilder UseChassiMiddleWare(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ChassiMiddleware>();
    }
}