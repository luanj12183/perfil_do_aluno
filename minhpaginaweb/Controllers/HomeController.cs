using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using minhpaginaweb.Models;

namespace minhpaginaweb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
    public IActionResult Index()
{
    ViewBag.Nome = "Luan"; 
    ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
    ViewBag.Semestre = "3º Semestre";
    
    return View();
}

        return View();
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
