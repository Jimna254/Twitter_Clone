using Assesment_9.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace Assesment_9.Services.Post
{
    
    public class PostService : IPostService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseUrl = "https://jsonplaceholder.typicode.com";

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public async Task<string> AddPostAsync(PostDTO newPost)
        {
           var request = JsonConvert.SerializeObject(newPost);
            var body = new StringContent(request, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{BaseUrl}/posts", body);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);


            if (content != null)
            {
                return content;
            }
            return "error occures";

        }

        public Task<PostDTO> GetPostByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostDTO>> GetPostsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
