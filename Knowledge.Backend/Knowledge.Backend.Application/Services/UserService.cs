using AutoMapper;
using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Application.Interfaces;
using Knowledge.Backend.Domain.Entidades;
using Knowledge.Backend.Domain.Interfaces;

namespace Knowledge.Backend.Application.Services
{
    internal class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetUsersAsync()
        {
            var users = await _userRepository.GetUsersAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<UserDTO> GetUserByIdAsync(int? id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> GetUserByNameAsync(string? name)
        {
            var user = await _userRepository.GetUsersByNameAsync(name);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task CreateUserAsync(UserDTO userDTO)
        {
            var userEntity = _mapper.Map<User>(userDTO);
            await _userRepository.CreateUserAsync(userEntity);
        }

        public async Task UpdateUserAsync(UserDTO userDTO)
        {
            var userEntity = _mapper.Map<User>(userDTO);
            await _userRepository.UpdateUserAsync(userEntity);
        }

        public async Task DeleteUserAsync(int? id)
        {
            var user = _userRepository.GetUserByIdAsync(id).Result;
            await _userRepository.DeleteUserAsync(user);
        }
    }
}
