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

        [HttpPost]
        public async Task<IActionResult> InsertLeaderBoard(Leaderboard leaderboard)
        {
            try
            {
                // Insert művelet
                var insertQuery = $"INSERT INTO Leaderboard (ID, Datum, JatekosNev, RekordIdo) " +
                                  $"VALUES ({leaderboard.ID}, '{leaderboard.Datum}', '{leaderboard.JatekosNev}', {leaderboard.RekordIdo});";

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
            catch (Exception ex)
            {
                return StatusCode(500, $"Hiba történt: {ex.Message}");
            }
        }
        public IActionResult Leaderboard()
        {
            return View();
        }
    }
}
