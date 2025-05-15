namespace TP04_schnaider.Models;


public class Juego
{
    public string palabra {get; private set;}
    public int intentos{get; private set;}
    public List<char>letrasUtilizadas{get; private set;}
    public char[] caracteres {get; private set;}
    public string palabraIntento{get; private set;}    
   
    public char[] caracteresIntento {get; private set;}
    public Juego()
    {
      
        palabra = "OTORRINOLARINGOLOGO";
        caracteres = palabra.ToCharArray();
        intentos = 0;
        palabraIntento = "-------------------";
        caracteresIntento = palabraIntento.ToCharArray();
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
     public char[] VerificarLetra(char letra){
      
      for(int i = 0; i <= caracteres.Length; i++){
                if (letra == caracteres[i]){
                  caracteresIntento[i] = letra;
                }
            }
            
            return caracteresIntento;
     }

     
}