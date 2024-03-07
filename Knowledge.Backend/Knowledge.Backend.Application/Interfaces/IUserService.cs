using Knowledge.Backend.Application.DTOs;

namespace Knowledge.Backend.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetUsersAsync();
        Task<UserDTO> GetUserByIdAsync(int? id);
        Task<UserDTO> GetUserByNameAsync(string? name);
        Task CreateUserAsync(UserDTO userDTO);
        Task UpdateUserAsync(UserDTO userDTO);
        Task DeleteUserAsync(int? id);
    }
}
