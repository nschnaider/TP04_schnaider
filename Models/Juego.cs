namespace TP04_schnaider.Models;


public static class Juego
{
    public static Palabra palabra {get; private set;}
    public static int intentos{get; private set;}
    public static List<char>letrasUtilizadas{get; private set;}
     
     public static void iniciarJuego()
     {
        
        this.palabra = new Palabra("OTORRINOLARINGOLOGO", new List<char>('O',''));
     }
}