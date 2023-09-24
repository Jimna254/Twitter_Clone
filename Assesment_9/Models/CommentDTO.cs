namespace Assesment_9.Models
{
    public class CommentDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
        public int postId { get; set; }
    }
}
