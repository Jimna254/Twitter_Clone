using Assesment_9.Models;

namespace Assesment_9.Services.Posts
{
    public interface IPostService
    {
        Task<List<PostDTO>> GetPostsAsync();



    }
}
