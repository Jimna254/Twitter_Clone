using Assesment_9.Models;

namespace Assesment_9.Services.Post
{
    public interface IPostService
    {
        Task<List<PostDTO>> GetPostsAsync();
        Task<PostDTO> GetPostByIdAsync(Guid Id);

        Task<string> AddPostAsync(PostDTO newPost);
    }
}
