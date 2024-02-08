using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;
using TechMed.Core.Exceptions;
using TechMed.Infrastructure.Persistence.Auth;

namespace TechMed.Application.Services;
public class LoginService : ILoginService
{
    private readonly IAuthService _authService;
    public LoginService(IAuthService authService)
    {
        _authService = authService;
    }
    public LoginViewModel? Authenticate(LoginInputModel login)
    {
        var passHash = _authService.ComputeSha256Hash(login.Password);
        if (login.Username == "admin" && passHash == _authService.ComputeSha256Hash("admin"))
        {
            var token = _authService.GenerateJwtToken(login.Username, "admin");
            return new LoginViewModel
            {
                Username = login.Username,
                Token = token
            };
        }
        return null;
    }
}
