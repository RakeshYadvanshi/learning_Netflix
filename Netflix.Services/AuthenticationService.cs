using Netflix.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Netflix.Services
{
    public class AuthenticationService : IAuthenticationService
    {

        public AuthenticationService()
        {

        }
        public async Task<User> ValidateEmailAndPasword(string email, string password)
        {
            
            
            var _email = "rky";
            var _password = "12345";
            if (_email == email && password == _password)
            {
                return new User
                {
                    Id = 90809,
                    Email = _email
                };
            }

            else
                return null;

        }
    }
}
