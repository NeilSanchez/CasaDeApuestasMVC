using CasaDeApuestasMVC.Models;
using Newtonsoft.Json;

namespace CasaDeApuestasMVC.Services
{
    public class EquiposService
    {
        public static async Task<IEnumerable<EquiposModel>> GetAll()
        {
            //Get all Users
            String urlBase = "http://localhost:5001/api/Equipos/";

            var client = new HttpClient();
            var response = await client.GetAsync(urlBase + "GetAll");
            string result = await response.Content.ReadAsStringAsync();
            var equipos = JsonConvert.DeserializeObject<IEnumerable<EquiposModel>>(result);
            return equipos;

        }
    }
}
