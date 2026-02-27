using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArchLab.Models;


namespace ArchLab.Controllers;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGreetingService _greetingService;

        public HomeController(ILogger<HomeController> logger, IGreetingService greetingService)
        {
            _logger = logger;
            _greetingService = greetingService;
        }

        public IActionResult Index()
        {
            ViewBag.Greeting = _greetingService.GetGreeting("Developer");
            return View();
        }
    }
