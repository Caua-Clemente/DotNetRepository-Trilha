using projMid.WebApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.UseChassiMiddleWare();

app.UseMotorMiddleWare();

app.UsePortasMiddleWare();

app.UsePinturaMiddleWare();

app.UseInternoMiddleWare();

app.Run();
