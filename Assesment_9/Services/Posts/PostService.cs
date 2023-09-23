using Assesment_9.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace Assesment_9.Services.Posts
{

    public class PostService : IPostService
    {
        private readonly HttpClient _httpClient;
        private readonly string PostsUrl = "https://jsonplaceholder.typicode.com/posts";

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }


        public async Task<List<PostDTO>> GetPostsAsync()
        {

            var response = await _httpClient.GetAsync($"{PostsUrl}");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<PostDTO>>(content);


            if (results != null)
            {
                return results;
            }

            return new List<PostDTO>();
        }
    }
}
