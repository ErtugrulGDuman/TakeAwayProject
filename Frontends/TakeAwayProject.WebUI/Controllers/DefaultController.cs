using Microsoft.AspNetCore.Mvc;

namespace TakeAwayProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
