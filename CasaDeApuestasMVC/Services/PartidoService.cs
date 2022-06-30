using CasaDeApuestasMVC.Models;
using Newtonsoft.Json;

namespace CasaDeApuestasMVC.Services
{
    public class PartidoService
    {
        public static async Task<IEnumerable<PartidoModel>> GetAll()
        {
            //Get all Users
            String urlBase = "http://localhost:5001/api/Partido/";

            var client = new HttpClient();
            var response = await client.GetAsync(urlBase + "GetAll");
            string result = await response.Content.ReadAsStringAsync();
            var partido = JsonConvert.DeserializeObject<IEnumerable<PartidoModel>>(result);
            return partido;

        }
    }
}
