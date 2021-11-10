using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNP1Assignment3.Models;

namespace DNP1Assignment3.Data.Impl
{
    public class FamilyDataAsync : IFamilyData
    {
        private string uri = "https://localhost:5003";

        public async Task<IList<Family>> GetFamilies()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(uri + "/Family");

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();

            List<Family> families = JsonSerializer.Deserialize<List<Family>>(result,
                new JsonSerializerOptions(new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                }));
            return families;
        }

        public async Task AddFamily(Family family)
        {
            using HttpClient client = new HttpClient();
            string newFamily = JsonSerializer.Serialize(family);
            StringContent content = new StringContent(newFamily, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync(uri + "/Family", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }

        public async Task RemoveFamily(int familyId)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync(uri + $"/Family/{familyId}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }

        public async Task UpdateFamily(Family family)
        {
            using HttpClient client = new HttpClient();
            string newFamily = JsonSerializer.Serialize(family);
            HttpContent content = new StringContent(newFamily, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PatchAsync($"{uri}/Family/{family.Id}", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }

        public async Task<Family> Get(int familyId)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(uri + $"/Family/{familyId}");
            
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();
            
            Family family = JsonSerializer.Deserialize<Family>(result, new JsonSerializerOptions(new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }));
            return family;
        }
    }
}