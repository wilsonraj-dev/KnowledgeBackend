using Knowledge.Backend.Domain.Entidades;
using Knowledge.Backend.Domain.Interfaces;
using Knowledge.Backend.Infra.Data.Context;

namespace Knowledge.Backend.Infra.Data.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Article>> GetArticlesAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Article> GetArticleByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
        public Task<Article> GetArticleByNameAsync(string? name)
        {
            throw new NotImplementedException();
        }
        public Task<Article> CreateArticleAsync(Article article)
        {
            throw new NotImplementedException();
        }
        public Task<Article> UpdateArticleAsync(Article article)
        {
            throw new NotImplementedException();
        }
        public Task<Article> DeleteArticleAsync(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
