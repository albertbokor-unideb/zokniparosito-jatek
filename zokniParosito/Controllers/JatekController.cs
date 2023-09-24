using Microsoft.AspNetCore.Mvc;
using System.Numerics;
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
        public IActionResult Game_Hu(string playerName, int selectedDifficult)
        {
            playerName = Uri.UnescapeDataString(playerName);
            ViewData["Diff"] = selectedDifficult;
            ViewData["Name"] = playerName;

            return View();
        }

        public IActionResult Game_En(string playerName, int selectedDifficult)
        {
            playerName = Uri.UnescapeDataString(playerName);
            ViewData["Diff"] = selectedDifficult;
            ViewData["Name"] = playerName;
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
        public async Task<IActionResult> GetZoknikByNehezseg(int nehezseg)
        {
            // Lekérdezés az összes adatból
            var query = "SELECT * FROM Zokni WHERE PalyaID ='"+ nehezseg + "'ORDER BY RAND() LIMIT 5;";
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
        [HttpGet]
        public async Task<IActionResult> GetPalyakByFokozat(int fokozat)
        {
            var query = "SELECT * FROM Palyak WHERE PalyaID ='"+ fokozat +"';";
            var palyak = await _databaseService.QueryToJsonAsync<PalyaModel>(query);

            if (palyak == null)
            {
                // Hiba: Nem találhatók pályák a megadott fokozattal
                return NotFound();
            }

            return Ok(palyak);
        }



        public IActionResult Jatek()
        {
            return View();
        }
    }
}
