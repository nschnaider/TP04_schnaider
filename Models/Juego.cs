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
    // Lista de palabras en mayúsculas
    List<string> palabras = new List<string>
    {
        "ALUMINIO", "BISAGRA", "CIRCUITO", "DIFUSOR", "ENFERMO", "FIBRILAR", "GLOBO", "HIDRATADO", "INMUNIDAD", "JERINGA",
        "KILOGRAMO", "LUMINOSO", "MECANISMO", "NEURONAS", "OXIGENO", "PULMONES", "QUIMICA", "REACTOR", "SISTEMA", "TELEFONO",
        "ULTRASONIDO", "VITAMINA", "WIFI", "XENOFOBIA", "YODO", "ZINC", "ACELERADOR", "BALON", "CIRUGIA", "DOPAMINA",
        "ELECTRODO", "FIBRA", "GASES", "HORMONAS", "INMUNOGLOBULINA", "JUGUETE", "KINESIOLOGO", "LENTES", "MUSCULO", "NEURONIO",
        "OXIMETRO", "PULSACION", "QUIMIOTERAPIA", "REHABILITACION", "SANGRE", "TERAPIA", "ULCERA", "VIRUS", "WALDORF", "XENON",
        "YOGUR", "ZAPATO", "ANTIBIOTICO", "BANDA", "CIRCUITOS", "DIALISIS", "ELECTRICIDAD", "FISIOLOGIA", "GENETICA", "HEMOGLOBINA",
        "INMUNIZACION", "JERINGUILLA", "KARATE", "LENGUAJE", "MELANINA", "NEUROTRANSMISOR", "OXIMETRIA", "PULMONAR", "QUIMICOS",
        "REACTIVOS", "SISTEMICO", "TELEMETRIA", "ULTRAFINO", "VITAMINICO", "WIFI", "XENOLOGIA", "YODO", "ZONIFICACION", "ALERGENO",
        "BISINUSITIS", "CIRUGIA", "DOPAMINERGICO", "ELECTROENCEFALOGRAFIA", "FIBRILACION", "GASTRITIS", "HEMORRAGIA", "INMUNODEFICIENCIA",
        "JUGUETERO", "KINESIOLOGIA", "LUMINOSIDAD", "MALARIA", "NEUMONIA", "OXIGENACION", "PULSOMETRO", "QUIMIOTERAPICO", "REHABILITADOR",
        "SANGRIENTO", "TERAPEUTICO", "ULCERA", "VIRULENTO", "WIFI", "XENOFOBICO", "YOGURTERIA", "ZONIFICACION"
    };
    Random random = new Random();
    palabra = palabras[random.Next(palabras.Count)];
    caracteres = palabra.ToCharArray();
    intentos = 0;
    caracteresIntento = new char[caracteres.Length];
    for (int i = 0; i < caracteresIntento.Length; i++)
    {
        caracteresIntento[i] = '_';
    }
    letrasUtilizadas = new List<char>();
}
    public static int sumarIntentos()
     {
        intentos++;
        return intentos;
     }
     public static List<char> agregarLetra(char letra){
        letrasUtilizadas.Add(letra);
        foreach(char l in letrasUtilizadas){
          Console.WriteLine(l);
        }
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