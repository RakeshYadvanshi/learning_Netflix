using Netflix.Models;

namespace Netflix.Services
{
    public interface IAuthenticationService
    {
        User ValidateEmailAndPasword(string email, string password);
    }
}
