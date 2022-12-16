using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortfolioV2.WebApp.Models;

namespace PortfolioV2.WebApp.Controllers;

public class DashboardController : Controller
{
    public DashboardController()
    {
    }

    public IActionResult Index()
    {
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
