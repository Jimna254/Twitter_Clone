using Assesment_9.Models;
using Newtonsoft.Json;

namespace Assesment_9.Services.User
{
    public class UserService : IUserService

    {
        private readonly HttpClient _httpclient;
        private readonly string userURL = "https://jsonplaceholder.typicode.com/comments  ";
        public UserService(HttpClient httpClient)
        {
           _httpclient = httpClient;

        }
        public async Task<List<UserDTO>> GetUsersAsync()
        {
            var response = await _httpclient.GetAsync(userURL);
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<UserDTO>>(response.ToString());
            if (results != null)
            {
                return results;
            }
            return new List<UserDTO>();

        }
    }
}
