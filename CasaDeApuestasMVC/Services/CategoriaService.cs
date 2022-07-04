using CasaDeApuestasMVC.Models;
using Newtonsoft.Json;
using System.Text;

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
        public static async Task<CategoriaModel> GetCategoria(int id)
        {
            //Get All using HttpClient
            string urlBase = "http://localhost:5001/api/Categoria/";

            using var httpClient = new HttpClient();
            using var response = await httpClient.GetAsync(urlBase + "GetById/" + id);
            string apiResponse = response.Content.ReadAsStringAsync().Result;
            var categoria = JsonConvert.DeserializeObject<CategoriaModel>(apiResponse);
            return categoria;
        }

        //Create new Categoria
        public static async Task<bool> Insert(CategoriaModel categoria)
        {
            string urlBase = "http://localhost:5001/api/Categoria/";

            using var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(categoria);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            using var response = await httpClient.PostAsync(urlBase + "Insert", stringContent);
            string apiResponse = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<bool>(apiResponse);
            return result;
        }

        //Update Categoria
        public static async Task<bool> Update(int id, CategoriaModel categoria)
        {
            string urlBase = "http://localhost:5001/api/Categoria/";
            using var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(categoria);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            using var response = await httpClient.PutAsync(urlBase + "Update/" + id, stringContent);
            string apiResponse = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<bool>(apiResponse);
            return result;
        }
        //Delete Categoria
        public static async Task<bool> Delete(int id)
        {
            string urlBase = "http://localhost:5001/api/Categoria/";
            using var httpClient = new HttpClient();
            using var response = await httpClient.DeleteAsync(urlBase + "Delete/" + id);
            string apiResponse = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<bool>(apiResponse);
            return result;
        }
    }
}
