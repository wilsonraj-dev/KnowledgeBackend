using Knowledge.Backend.Domain.Entidades;
using Knowledge.Backend.Domain.Interfaces;
using Knowledge.Backend.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Knowledge.Backend.Infra.Data.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Article>> GetArticlesAsync()
        {
            return await _context.Articles.ToListAsync();
        }

        public async Task<Article> GetArticleByIdAsync(int? id)
        {
            return await _context.Articles.FindAsync(id);
        }

        public async Task<IEnumerable<Article>> GetArticlesByCategoryAsync(int idCategory)
        {
            return await _context.Articles.Where(x => x.CategoryId == idCategory).ToListAsync();
        }

        public async Task<IEnumerable<Article>> GetArticlesByNameAsync(string? name)
        {
            return await _context.Articles.Where(x => x.Name.Contains(name)).ToListAsync();
        }

        public async Task<Article> CreateArticleAsync(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
            return article;
        }

        public async Task<Article> UpdateArticleAsync(Article article)
        {
            _context.Articles.Update(article);
            await _context.SaveChangesAsync();
            return article;
        }

        public async Task<Article> DeleteArticleAsync(Article article)
        {
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return article;
        }
    }
}
