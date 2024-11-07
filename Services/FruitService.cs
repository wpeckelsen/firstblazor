using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using firstblazor.Models;


namespace firstblazor.Services
{
    public class FruitService
    {

        private readonly HttpClient _httpClient;




        public FruitService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("FruitAPI");
        }


        public async Task<List<Fruit>> GetAllFruitsAsync()
        {
            var fruits = await _httpClient.GetFromJsonAsync<List<Fruit>>("fruit");
            return fruits;
        }


        public async Task<Fruit> GetFruitByIdAsync(int id)
        {
            var fruit = await _httpClient.GetFromJsonAsync<Fruit>($"fruit/{id}");
            return fruit;
        }

        public async Task CreateFruitAsync(Fruit newFruit)
        {
            var response = await _httpClient.PostAsJsonAsync("https://65c4b379dae2304e92e3264b.mockapi.io/api/v1/fruit", newFruit);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("error creating Fruit");
            }
        }


        



    }
}