using CasaDeApuestasMVC.Models;
using Newtonsoft.Json;

namespace CasaDeApuestasMVC.Services
{
    public class CategoriasService
    {
        public static async Task<IEnumerable<CategoriaModel>> GetAll()
        {
            //Get all Categorias
            String urlBase = "http://localhost:5001/api/Categoria/";

            var client = new HttpClient();
            var response = await client.GetAsync(urlBase + "GetAll");
            string result = await response.Content.ReadAsStringAsync();
            var categorias = JsonConvert.DeserializeObject<IEnumerable<UsuarioModel>>(result);
            return categorias;

        }
    }
}
