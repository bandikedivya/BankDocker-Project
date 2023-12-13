using BankDockerLogin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankDockerLogin.Controllers
{
    public class AccountController : Controller
    {
        // Simulated user data (replace with your actual authentication logic)
        private readonly User _user = new User
        {
            Id = 1,
            //Username = "maximus",
            //Password = "perseus"
        };
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
       public IActionResult Login(User model)
        //{
            //if (ModelState.IsValid && Username == _user.Username && Password
          // == _user.Password)
            {
                // Successful login, redirect to dashboard
                return RedirectToAction("Index", "Dashboard");
            }
            // Invalid login, show error message
           // ModelState.AddModelError("", "Invalid username or password");
            //return View(model);
        }
    }
