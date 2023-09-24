using Assesment_9.Models;

namespace Assesment_9.Services.User
{
    public interface IUserService
    {
        public Task<List<UserDTO>> GetUsersAsync();

        
    }
}
