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
        Juego.inicializarJuego();
        ViewBag.palabraIntento = Juego.caracteresIntento;
        ViewBag.letras = Juego.letrasUtilizadas;
        return View();
    }
   public IActionResult IntentoLetra(char letra)
{
    int intentos = Juego.intentos;
    List<char> letras = Juego.letrasUtilizadas;
    char[] carIntento = Juego.caracteresIntento;
    
        if (!Juego.letrasUtilizadas.Contains(letra))
        {
        carIntento = Juego.VerificarLetra(letra);
        letras = Juego.agregarLetra(letra);
        intentos = Juego.sumarIntentos();

        }
    else
    {
        ViewBag.error = "Ya intentaste esa letra";
    }

    ViewBag.intentos = intentos;
    ViewBag.letras = letras;
    ViewBag.palabraIntento = carIntento;

 if (Juego.palabra == new string(carIntento))
        {
            string resultado = "Ganaste!";
            ViewBag.resultado = resultado;
            ViewBag.palabra = Juego.palabra;
            return View("Resultado");
        }
    return View("Index");
}
   public IActionResult IntentoPalabra(string palabra)
   {
        
        string resultado;
        if (palabra != null){
           if (palabra == Juego.palabra){
            
             resultado = "Ganaste!";
           }
           else{
            resultado = "Perdiste...";
           }
           ViewBag.palabra = Juego.palabra;
           ViewBag.resultado = resultado;
           
        }
        return View("Resultado");
   }
}
