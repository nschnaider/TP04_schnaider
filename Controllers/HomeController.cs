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
        return View();
    }
   public IActionResult IntentoLetra(char letra)
   {
        
        
        
        if (letra != null){
            if(!Juego.letrasUtilizadas.Contains(letra)){
            char[] carIntento = Juego.VerificarLetra(letra);
           ViewBag.palabraIntento = carIntento;
           List<char> letrass = Juego.agregarLetra(letra);
           ViewBag.letras = letrass;
           int intentos = Juego.sumarIntentos();
           ViewBag.intentos = intentos;
            }
            else{
                ViewBag.error = "Ya intentaste esa letra";
            }
           
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
