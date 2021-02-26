namespace Netflix.Services
{
    public class AuthenticationService : IAuthenticationService
    {

        public AuthenticationService()
        {

        }
        public bool ValidateEmailAndPasword(string email, string password)
        {
            var _email = "rk@gmail.com";
            var _password = "12345";
            if (_email == email && password == _password)
            {
                return true;
            }

            else
                return false;

        }
    }
}
