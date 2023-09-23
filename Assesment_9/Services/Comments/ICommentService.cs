using Assesment_9.Models;

namespace Assesment_9.Services.Comments
{
    public interface ICommentService
    {
        Task<List<CommentDTO>> GetCommentsAsync();
        Task<List<CommentDTO>> GetCommentsByPostAsync(int id);
    }
}
