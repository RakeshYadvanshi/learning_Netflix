using Microsoft.AspNetCore.Mvc;
using Netflix.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Netflix.Services;
namespace Netflix.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var isLogined = authenticationService.ValidateEmailAndPasword(loginViewModel.Email, loginViewModel.Password);

            if (isLogined == true)
            {
                TempData["Email"] = loginViewModel.Email;
                return RedirectToAction("MyAccount", "Account");
            }

            ViewBag.IsInvalidCreds = true;
            return View(loginViewModel);
        }

    }
}
