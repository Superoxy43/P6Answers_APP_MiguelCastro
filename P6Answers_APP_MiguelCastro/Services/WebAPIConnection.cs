using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6Answers_APP_MiguelCastro.Services
{
    public static class WebAPIConnection
    {
        //Esta clase auto instanciada permite configurar la ruta de consumo base del servicio web API. 
        //Normalmente es un nombre DNS como www.misitio.com/api/
        //o la dirección IP del servidor como por ejemplo 85.25.45.10/api o local como 192.168.0.10

        public static string BaseURL = "http://192.168.0.4:45455/api/";
        //acá también es importante incluir la infor de seguridad como el API Key
        //ya que debe ser incluido en cada llamada a los end point del API

        public static string ApiKeyName = "ApiKey";
        public static string ApiKeyValue = "MiguelP620242f2470";

        //también vamos a incluir (si es necesario) la forma como se va a codificar los paquetes json 
        //que serán enviados y recibidos del API

        public static string MimeType = "application/json";
        public static string ContentType = "Content-Type";


    }
}
