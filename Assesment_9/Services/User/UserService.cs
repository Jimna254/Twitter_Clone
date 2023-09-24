using Assesment_9.Models;
using Newtonsoft.Json;

namespace Assesment_9.Services.User
{
    public class UserService : IUserService

    {
        private readonly HttpClient _httpclient;
        private readonly string userURL = "https://jsonplaceholder.typicode.com/users";
        public UserService(HttpClient httpClient)
        {
           _httpclient = httpClient;

        }


        public async Task<List<UserDTO>> GetUsersAsync()
        {
            var response = await _httpclient.GetAsync(userURL);
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<UserDTO>>(content.ToString());
            Console.WriteLine(results);

            if (results != null)
            {
                return results;
            }
            return new List<UserDTO>();

        }
    }
}
