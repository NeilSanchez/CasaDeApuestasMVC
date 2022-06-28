using Newtonsoft.Json;
using CasaDeApuestasMVC.Models;

namespace CasaDeApuestasMVC.Services
{
    public class UsuarioService
    {
        public static async Task<IEnumerable<UsuarioModel>> GetAll()
        {
            //Get all Users
            String urlBase = "http://localhost:5001/api/Usuario/";

            var client = new HttpClient();
            var response = await client.GetAsync(urlBase + "GetAll");
            string result = await response.Content.ReadAsStringAsync();
            var usuario = JsonConvert.DeserializeObject<IEnumerable<UsuarioModel>>(result);
            return usuario;

        }
    }
}
