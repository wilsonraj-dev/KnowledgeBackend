using Knowledge.Backend.Application.DTOs;

namespace Knowledge.Backend.Application.Interfaces
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleDTO>> GetArticlesAsync();
        Task<ArticleDTO> GetArticleByIdAsync(int? id);
        Task<ArticleDTO> GetArticleByNameAsync(string? name);
        Task CreateArticleAsync(ArticleDTO article);
        Task UpdateArticleAsync(ArticleDTO article);
        Task DeleteArticleAsync(int? id);
    }
}
