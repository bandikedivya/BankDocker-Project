using Microsoft.AspNetCore.Mvc;

namespace BankDockerLogin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
