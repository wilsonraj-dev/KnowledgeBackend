using Knowledge.Backend.Domain.Entidades;
using Knowledge.Backend.Domain.Interfaces;
using Knowledge.Backend.Infra.Data.Context;

namespace Knowledge.Backend.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<User>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }
        public Task<User> GetUserByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
        public Task<User> GetUserByNameAsync(string? name)
        {
            throw new NotImplementedException();
        }
        public Task<User> CreateUserAsync(User article)
        {
            throw new NotImplementedException();
        }
        public Task<User> UpdateUserAsync(User article)
        {
            throw new NotImplementedException();
        }
        public Task<User> DeleteUserAsync(User article)
        {
            throw new NotImplementedException();
        }
    }
}
