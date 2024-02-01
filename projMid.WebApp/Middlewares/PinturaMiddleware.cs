namespace projMid.WebApp.Middlewares;
public class PinturaMiddleware
{
    private readonly RequestDelegate _next;
    public PinturaMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Add Pintura --> ");
        await _next .Invoke(context);
    }
}

public static class PinturaMiddlewareExtensions
{
    public static IApplicationBuilder UsePinturaMiddleWare(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<PinturaMiddleware>();
    }
}