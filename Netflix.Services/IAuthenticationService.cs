using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Services
{
    public interface IAuthenticationService
    {
        bool ValidateEmailAndPasword(string email, string password);
    }
}
