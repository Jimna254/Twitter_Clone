
using Assesment_9.Models;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Assesment_9.Services.Comments
{
    public class CommentsService : ICommentService
    {
        private readonly HttpClient _httpClient;
        private readonly string CommentsUrl = "https://jsonplaceholder.typicode.com/users ";

        public CommentsService(HttpClient httpClient)
        {
            _httpClient = httpClient;


        }
        public async Task<List<CommentDTO>> GetCommentsAsync()
        {
            var response = await _httpClient.GetAsync($"{CommentsUrl}");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<CommentDTO>>(content);


            if (results != null)
            {
                return results;
            }

            return new List<CommentDTO>();
        }

        public async Task<List<CommentDTO>> GetCommentsByPostAsync(int id)
        {
            var res = await _httpClient.GetAsync($"{CommentsUrl}");
            var response = await res.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<CommentDTO>>(response.ToString());
            if (results != null)
            {
                return results;
            }
            return new List<CommentDTO>();
        }
    }
}
