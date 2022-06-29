using CasaDeApuestasMVC.Models;
using Newtonsoft.Json;

namespace CasaDeApuestasMVC.Services
{
    public class CategoriaService
    {
        public static async Task<IEnumerable<CategoriaModel>> GetAll()
        {
            //Get all Categorias
            String urlBase = "http://localhost:5001/api/Categoria/";

            var client = new HttpClient();
            var response = await client.GetAsync(urlBase + "GetAll");
            string result = await response.Content.ReadAsStringAsync();
            var categoria = JsonConvert.DeserializeObject<IEnumerable<CategoriaModel>>(result);
            return categoria;

        }
    }
}
