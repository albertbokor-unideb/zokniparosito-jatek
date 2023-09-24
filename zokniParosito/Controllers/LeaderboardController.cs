using Microsoft.AspNetCore.Mvc;
using zokniParosito.Database;
using zokniParosito.Models;

namespace zokniParosito.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly ILogger<LeaderboardController> _logger;
        private readonly IConfiguration _configuration;
        private readonly DatabaseService _databaseService;
        public LeaderboardController(IConfiguration configuration, DatabaseService databaseService)
        {
            _configuration = configuration;
            _databaseService = databaseService;
        }
        [HttpGet]
        public async Task<IActionResult> GetLeaderBoard()
        {
            // Lekérdezés az összes adatból
            var query = "SELECT * FROM Leaderboard;";
            var leaderboardData = await _databaseService.QueryToJsonAsync<Leaderboard>(query);
            return Ok(leaderboardData);
        }
        [HttpGet]
        public async Task<IActionResult> GetLeaderBoardTopEasy()
        {
            // Lekérdezés az összes adatból
            var query = "SELECT * FROM Leaderboard;";
            var leaderboardData = await _databaseService.QueryToJsonAsync<Leaderboard>(query);
            return Ok(leaderboardData);
        }
        public async Task<IActionResult> GetLeaderBoardTopMedium()
        {
            // Lekérdezés az összes adatból
            var query = "SELECT * FROM Leaderboard;";
            var leaderboardData = await _databaseService.QueryToJsonAsync<Leaderboard>(query);
            return Ok(leaderboardData);
        }
        public async Task<IActionResult> GetLeaderBoardTopHard()
        {
            // Lekérdezés az összes adatból
            var query = "SELECT * FROM Leaderboard;";
            var leaderboardData = await _databaseService.QueryToJsonAsync<Leaderboard>(query);
            return Ok(leaderboardData);
        }

        [HttpPost]
        public async Task<IActionResult> InsertLeaderBoard(string JatekosNev, string RekordIdo, string PalyaID)
        {
            try
            {
                // Időintervallum parszolása TimeSpan-tá
                TimeSpan rekordIdo;
                if (TimeSpan.TryParse(RekordIdo, out rekordIdo))
                {
                    // Insert művelet
                    var insertQuery = $"INSERT INTO Leaderboard (Datum, JatekosNev, RekordIdo, PalyaID) " +
                                      $"VALUES ('{DateTime.Now.Date.ToString("yyyy-MM-dd")}', '{JatekosNev}', '{rekordIdo}','{PalyaID}');";

                    var success = await _databaseService.ExecuteNonQueryAsync(insertQuery);

                    if (success)
                    {
                        return Ok("Sikeres beszúrás");
                    }
                    else
                    {
                        return BadRequest("Beszúrás sikertelen");
                    }
                }
                else
                {
                    // Időintervallum parszolása sikertelen
                    return BadRequest("Érvénytelen időformátum");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500, $"Hiba történt: {ex.Message}");
            }
        }


        public IActionResult leaderboard_hu()
        {
            return View();
        }
        public IActionResult leaderboard_en()
        {
            return View();
        }
    }
}
