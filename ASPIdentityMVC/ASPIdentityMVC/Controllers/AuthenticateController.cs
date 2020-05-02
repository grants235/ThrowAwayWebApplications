using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPIdentityMVC.Controllers
{
    public class AuthenticateController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CheckUser(string username, string password)
        {

        }

        public IActionResult Register()
        {
            return View();
        }
    }
}