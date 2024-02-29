using Knowledge.Backend.Domain.Entidades;

namespace Knowledge.Backend.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int? id);
        Task<User> GetUserByNameAsync(string? name);
        Task<User> CreateUserAsync(User article);
        Task<User> UpdateUserAsync(User article);
        Task<User> DeleteUserAsync(User article);
    }
}
