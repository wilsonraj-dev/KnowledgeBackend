using Knowledge.Backend.Application.DTOs;

namespace Knowledge.Backend.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetUsersDTOAsync();
        Task<UserDTO> GetUserDTOByIdAsync(int? id);
        Task<UserDTO> GetUserDTOByNameAsync(string? name);
        Task CreateUserDTOAsync(UserDTO userDTO);
        Task UpdateUserDTOAsync(UserDTO userDTO);
        Task DeleteUserDTOAsync(int? id);
    }
}
