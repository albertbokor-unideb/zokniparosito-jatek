using Microsoft.AspNetCore.Mvc;

namespace zokniParosito.Controllers
{
    public class LeaderboardController : Controller
    {
        public IActionResult Leaderboard()
        {
            return View();
        }
    }
}
