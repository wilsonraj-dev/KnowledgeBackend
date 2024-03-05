using Knowledge.Backend.Domain.Entidades;

namespace Knowledge.Backend.Domain.Interfaces
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetArticlesAsync();
        Task<Article> GetArticleByIdAsync(int? id);
        Task<IEnumerable<Article>> GetArticlesByNameAsync(string? name);
        Task<Article> CreateArticleAsync(Article article);
        Task<Article> UpdateArticleAsync(Article article);
        Task<Article> DeleteArticleAsync(Article article);
    }
}
