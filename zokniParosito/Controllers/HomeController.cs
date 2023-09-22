using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using Newtonsoft.Json;
using System.Diagnostics;
using zokniParosito.Database;
using zokniParosito.Models;

namespace zokniParosito.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly DatabaseService _databaseService;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration,DatabaseService databaseService)
        {
            _logger = logger;
            _configuration = configuration;
            _databaseService = databaseService;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index_En()
        {
            return View();
        }
    }
}