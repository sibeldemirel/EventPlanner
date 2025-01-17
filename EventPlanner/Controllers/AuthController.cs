using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using EventPlanner.Models;

namespace EventPlanner.Controllers
{
    public class AuthController : Controller
    {
        private static readonly List<Participant> Participants = new()
        {
            new Participant {Id = "2", Name = "Charles", Password ="12345", Age=16, Email = "huicuto@gmail.com", PhoneNumber="0806566545", Role = "User"},
            new Participant {Id = "23", Name = "Bob", Password ="12345", Age=16, Email = "machiato@gmail.com", PhoneNumber="0806151546", Role = "User"},
        };

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = Participants.FirstOrDefault(u => u.Name == username && u.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Name);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Nom d'utilisateur ou mdp incorrect";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
