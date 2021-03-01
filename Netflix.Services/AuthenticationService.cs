using Netflix.Models;

namespace Netflix.Services
{
    public class AuthenticationService : IAuthenticationService
    {

        public AuthenticationService()
        {

        }
        public User ValidateEmailAndPasword(string email, string password)
        {
            var _email = "rk@gmail.com";
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
