using Knowledge.Backend.Domain.Entidades;
using Knowledge.Backend.Domain.Interfaces;
using Knowledge.Backend.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Knowledge.Backend.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int? id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersByNameAsync(string? name)
        {
            return await _context.Users.Where(x => x.Name.Contains(name)).ToListAsync();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUserAsync(User user)
        {
            _context.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
