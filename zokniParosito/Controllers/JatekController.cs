using Microsoft.AspNetCore.Mvc;

namespace zokniParosito.Controllers
{
    public class JatekController : Controller
    {
        public IActionResult Jatek()
        {
            return View();
        }
    }
}
