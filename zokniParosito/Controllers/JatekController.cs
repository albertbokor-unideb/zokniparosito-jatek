using Microsoft.AspNetCore.Mvc;
using zokniParosito.Database;
using zokniParosito.Models;

namespace zokniParosito.Controllers
{
    public class JatekController : Controller
    {
        private readonly ILogger<LeaderboardController> _logger;
        private readonly IConfiguration _configuration;
        private readonly DatabaseService _databaseService;
        public JatekController(IConfiguration configuration, DatabaseService databaseService)
        {
            _configuration = configuration;
            _databaseService = databaseService;
        }
        public IActionResult Game_Hu()
        {
            return View();
        }
        public IActionResult Game_En()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetZoknik()
        {
            // Lekérdezés az összes adatból
            var query = "SELECT * FROM Zokni;";
            var zoknik = await _databaseService.QueryToJsonAsync<Zokni>(query);
            return Ok(zoknik);
        }
        [HttpGet]
        public async Task<IActionResult> GetPalyak()
        {
            var query = "SELECT * FROM Palyak;";
            var palyak = await _databaseService.QueryToJsonAsync<PalyaModel>(query);
            return Ok(palyak);
        }
      
        public IActionResult Jatek()
        {
            return View();
        }
    }
}
