using Netflix.Models;
using System.Threading.Tasks;

namespace Netflix.Services
{
    public interface IAuthenticationService
    {
        Task<User> ValidateEmailAndPasword(string email, string password);
    }
}
