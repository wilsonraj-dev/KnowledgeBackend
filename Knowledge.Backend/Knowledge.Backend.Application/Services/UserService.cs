using AutoMapper;
using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Application.Interfaces;

namespace Knowledge.Backend.Application.Services
{
    internal class UserService : IUserService
    {
        private IUserService _userService;
        private readonly IMapper _mapper;

        public UserService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public Task<IEnumerable<UserDTO>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }
        public Task<UserDTO> GetUserByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
        public Task<UserDTO> GetUserByNameAsync(string? name)
        {
            throw new NotImplementedException();
        }
        public Task CreateUserAsync(UserDTO article)
        {
            throw new NotImplementedException();
        }
        public Task UpdateUserAsync(UserDTO article)
        {
            throw new NotImplementedException();
        }
        public Task DeleteUserAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
