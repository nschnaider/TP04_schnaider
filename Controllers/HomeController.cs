using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_schnaider.Models;

namespace TP04_schnaider.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    { 
        Juego juego = new Juego();
        ViewBag.caracteres = juego.caracteres;
        ViewBag.palabra = juego.palabra;
        return View();
    }
   public IActionResult IntentoJuego(char letra, string palabra)
   {
        
        return View("Index");
   }
}
