using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNP1Assignment3.Models;

namespace DNP1Assignment3.Data.Impl
{
    public class UserServiceAsync : IUserService
    {
        private string uri = "https://localhost:5003";
        public async Task CreateUser(User user)
        {
            using HttpClient client = new HttpClient();

            string newUser = JsonSerializer.Serialize(user);

            StringContent content = new StringContent
            (
                newUser,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage responseMessage = await client.PostAsync(uri + "/User", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            using HttpClient client = new HttpClient();
            Console.WriteLine("here1");
            HttpResponseMessage responseMessage = await client.GetAsync(uri + $"/User?username={userName}&password={password}");
            Console.WriteLine("here2");
            
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
            
            string result = await responseMessage.Content.ReadAsStringAsync();
            User user = JsonSerializer.Deserialize<User>(result, new JsonSerializerOptions(new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }));
            return user;
        }
    }
}