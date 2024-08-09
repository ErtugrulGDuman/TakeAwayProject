using Microsoft.AspNetCore.Mvc;

namespace TakeAwayProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
