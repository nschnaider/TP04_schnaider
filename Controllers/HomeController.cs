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
        ViewBag.palabraIntento = juego.palabraIntento;
        return View();
    }
   public IActionResult IntentoLetra(string letra2)
   {
        Juego juego = new Juego();
        char[] letras = letra2.ToCharArray();
        char letra = letras[0];
        if (letra != null){
            if(!juego.letrasUtilizadas.Contains(letra)){
            char[] carIntento = juego.VerificarLetra(letra);
           ViewBag.palabraIntento = carIntento;
           List<char> letrass = juego.agregarLetra(letra);
           ViewBag.letras = letrass;
           int intentos = juego.sumarIntentos();
           ViewBag.intentos = intentos;
            }
           
        }
        return View("Index");
   }
   public IActionResult IntentoPalabra(string palabra)
   {
        Juego juego = new Juego();
        string resultado;
        if (palabra != null){
           if (palabra == juego.palabra){
            
             resultado = "Ganaste!";
           }
           else{
            resultado = "Perdiste...";
           }
           ViewBag.palabra = juego.palabra;
           ViewBag.resultado = resultado;
           
        }
        return View("Resultado");
   }
}
