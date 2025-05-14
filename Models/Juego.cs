namespace TP04_schnaider.Models;


public class Juego
{
    public string palabra {get; private set;}
    public int intentos{get; private set;}
    public List<char>letrasUtilizadas{get; private set;}
    public char[] caracteres {get; private set;}
    public Juego()
    {
        palabra = "OTORRINOLARINGOLOGO";
        caracteres = palabra.ToCharArray();
        intentos = 0;
        letrasUtilizadas = new List<char>();
    }
     public int sumarIntentos()
     {
        intentos++;
        return intentos;
     }
     public List<char> agregarLetra(char letra){
        letrasUtilizadas.Add(letra);
        return letrasUtilizadas;
     }

     
}