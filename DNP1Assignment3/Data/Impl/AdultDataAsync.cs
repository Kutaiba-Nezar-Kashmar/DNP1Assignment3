using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNP1Assignment3.Models;

namespace DNP1Assignment3.Data.Impl
{
    public class AdultDataAsync : IAdultData
    {
        private string uri = "https://localhost:5003";
        public async Task<IList<Adult>> GetAdults()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(uri + "/Adult");

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();

            List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(result, new JsonSerializerOptions(new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }));
            return adults;
        }

        public async Task AddAdult(Adult adult)
        {
            using HttpClient client = new HttpClient();
            string newAdult = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(newAdult, Encoding.UTF8, "application/json");

            HttpResponseMessage  response = await client.PostAsync(uri + "/Adult", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task RemoveAdult(int adultId)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync(uri + $"/Adult/{adultId}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }

        public async Task UpdateAdult(Adult adult)
        {
            using HttpClient client = new HttpClient();
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PatchAsync($"{uri}/Adult/{adult.Id}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<Adult> Get(int adultId)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(uri + $"/Adult/{adultId}");

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();

            Adult adult = JsonSerializer.Deserialize<Adult>(result, new JsonSerializerOptions(new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }));
            return adult;
        }
    }
}