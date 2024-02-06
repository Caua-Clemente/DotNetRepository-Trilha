using System.Linq.Expressions;
using System.Text;

namespace AuthProj.WebAPI.Auth;
public class SimpleAuthHandler
{
    private readonly RequestDelegate _next;
    public SimpleAuthHandler(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        //Verifica se a requisição possui a chave "Authorization"
        if(!context.Request.Headers.ContainsKey("Authorization"))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Authorization header is missing");
            return;
        }

        //Verifica username e senha
        var header = context.Request.Headers["Authorization"].ToString();
        var encodedUsernamePassword = header.Substring(6);
        var decodedUsernamePassword = Encoding.UTF8.GetString(Convert.FromBase64String(encodedUsernamePassword));
        
        string[] usernamePassword = decodedUsernamePassword.Split(":");
        var username = usernamePassword[0];
        var password = usernamePassword[1];

        

        await _next(context);
    }
}
