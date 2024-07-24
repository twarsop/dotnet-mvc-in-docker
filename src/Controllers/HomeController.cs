using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DieRollerMVC.Models;

namespace DieRollerMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Random _random;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _random = new Random();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult DieRoll()
    {
        return Json(_random.Next(1,7));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
