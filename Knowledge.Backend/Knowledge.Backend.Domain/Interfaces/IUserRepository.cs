using Knowledge.Backend.Domain.Entidades;

namespace Knowledge.Backend.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int? id);
        Task<IEnumerable<User>> GetUsersByNameAsync(string? name);
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<User> DeleteUserAsync(User user);
    }
}
