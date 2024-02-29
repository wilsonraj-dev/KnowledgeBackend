using Knowledge.Backend.Domain.Entidades;

namespace Knowledge.Backend.Domain.Interfaces
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetArticlesAsync();
        Task<Article> GetArticleByIdAsync(int? id);
        Task<Article> GetArticleByNameAsync(string? name);
        Task<Article> CreateArticleAsync(Article article);
        Task<Article> UpdateArticleAsync(Article article);
        Task<Article> DeleteArticleAsync(Article article);
    }
}
