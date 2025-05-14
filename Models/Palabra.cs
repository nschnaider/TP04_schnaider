namespace TP04_schnaider.Models;


public class Palabra
{
    public string palabra {get; private set;}
    public List<char> letras{get; private set;}
     public Palabra (string palabra, List<char>letras)
     {
        this.palabra = palabra;
        this.letras = letras;
     }

}