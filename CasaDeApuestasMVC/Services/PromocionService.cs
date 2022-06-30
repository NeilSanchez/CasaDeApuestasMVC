using CasaDeApuestasMVC.Models;
using Newtonsoft.Json;

namespace CasaDeApuestasMVC.Services
{
    public class PromocionService
    {
        public static async Task<IEnumerable<PromocionModel>> GetAll()
        {
            //Get all Users
            String urlBase = "http://localhost:5001/api/Promocion/";

            var client = new HttpClient();
            var response = await client.GetAsync(urlBase + "GetAll");
            string result = await response.Content.ReadAsStringAsync();
            var promocion = JsonConvert.DeserializeObject<IEnumerable<PromocionModel>>(result);
            return promocion;

        }
    }
}
