using AutoMapper;
using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Application.Interfaces;
using Knowledge.Backend.Domain.Entidades;
using Knowledge.Backend.Domain.Interfaces;

namespace Knowledge.Backend.Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetUsersDTOAsync()
        {
            var users = await _userRepository.GetUsersAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<UserDTO> GetUserDTOByIdAsync(int? id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> GetUserDTOByNameAsync(string? name)
        {
            var user = await _userRepository.GetUsersByNameAsync(name);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task CreateUserDTOAsync(UserDTO userDTO)
        {
            var userEntity = _mapper.Map<User>(userDTO);
            await _userRepository.CreateUserAsync(userEntity);
        }

        public async Task UpdateUserDTOAsync(UserDTO userDTO)
        {
            var userEntity = _mapper.Map<User>(userDTO);
            await _userRepository.UpdateUserAsync(userEntity);
        }

        public async Task DeleteUserDTOAsync(int? id)
        {
            var user = _userRepository.GetUserByIdAsync(id).Result;
            await _userRepository.DeleteUserAsync(user);
        }
    }
}
