using Microsoft.AspNetCore.Mvc;
namespace apinet.Controllers
{
    public class PerfilPersonalController:Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "EYYYYY This is mi :vista";
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "EYYYYY This is mi :welcome papu";
            return View();
        }
    }
}