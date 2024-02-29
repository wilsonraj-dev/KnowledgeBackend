using Knowledge.Backend.Domain.Entidades;
using Knowledge.Backend.Domain.Interfaces;
using Knowledge.Backend.Infra.Data.Context;

namespace Knowledge.Backend.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Category> GetCategoryByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
        public Task<Category> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
        public Task<Category> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
        public Task<Category> DeleteCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
