using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netflix.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult MyAccount()
        {
            ViewBag.userEmail = HttpContext.Session.GetString("UserEmail");
            ViewBag.userId = HttpContext.Session.GetString("UserId");
            return View();
        }
    }
}
