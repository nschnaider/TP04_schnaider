namespace TP04_schnaider.Models;


public static class Juego
{
    public static string palabra {get; private set;}
    public static int intentos{get; private set;}
    public static List<char>letrasUtilizadas{get; private set;}
    public static char[] caracteres {get; private set;}
       
   
    public static char[] caracteresIntento {get; private set;}
    public static void inicializarJuego()
    {
      
        palabra = "OTORRINOLARINGOLOGO";
        caracteres = palabra.ToCharArray();
        intentos = 0;
        caracteresIntento = new char[caracteres.Length];
        for(int i = 0; i < caracteresIntento.Length; i++){
          caracteresIntento[i] = '_';
        
        letrasUtilizadas = new List<char>();
        }
    }
    public static int sumarIntentos()
     {
        intentos++;
        return intentos;
     }
     public static List<char> agregarLetra(char letra){
        letrasUtilizadas.Add(letra);
        return letrasUtilizadas;
     }
     public static char[] VerificarLetra(char letra){
      
      for(int i = 0; i < caracteres.Length; i++){
                if (letra == caracteres[i]){
                  caracteresIntento[i] = letra;
                }
            }
            
            return caracteresIntento;
     }

     
}