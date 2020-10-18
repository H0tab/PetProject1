using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetProject1.Models;

namespace PetProject1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(User user)
        {
            if (ModelState.IsValid)
            {
                return Content("Регистрация прошла успешно!");
            }
            else
            {
                return View();
            }
        }
    }
}
