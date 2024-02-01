namespace projMid.WebApp.Middlewares;
public class InternoMiddleware
{
    private readonly RequestDelegate _next;
    public InternoMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Add Interno");
    }
}

public static class InternoMiddlewareExtensions
{
    public static IApplicationBuilder UseInternoMiddleWare(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<InternoMiddleware>();
    }
}