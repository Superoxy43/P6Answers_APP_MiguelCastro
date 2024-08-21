using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace P6Answers_APP_MiguelCastro.Models
{
    public class User
    { 
        [JsonIgnore]
        public RestRequest Request { get; set; }

        public int UsuarioID { get; set; }

        public string Nombre { get; set; }

        public string? PApellido { get; set; }

        public string? SApellido { get; set; }

        public string? Telefono { get; set; }

        public string Contrasennia { get; set; }

        public int? StrikeCount { get; set; }

        public string? BackUpEmail { get; set; }

        public string? JobDescription { get; set; }

        public int UserStatusId { get; set; }

        public int CountryId { get; set; }

        public int UserRoleId { get; set; }

        //funcion login por id


        public async Task<List<User>?> GetUserAsync(int ID)
        {
            try
            {
                //este es el sufijo que completa la ruta de consumo del API
                string RouteSurfix = string.Format("Users/ConsultarUsuarioPorID");

                string URL = Services.WebAPIConnection.BaseURL + RouteSurfix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get); //donde se pone el verbo correspondiente 

                //agregamos la info de seguridad api key

                Request.AddHeader(Services.WebAPIConnection.ApiKeyName, Services.WebAPIConnection.ApiKeyValue);

                //se ejecuta la llamada

                RestResponse response = await client.ExecuteAsync(Request);

                //validamos el resultado del llamado del API
                HttpStatusCode statusCode = response.StatusCode;

                if (response != null && statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<User>>(response.Content);

                    return list;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }
    }
}
