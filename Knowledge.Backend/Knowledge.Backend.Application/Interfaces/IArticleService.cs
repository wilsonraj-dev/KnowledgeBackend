using Knowledge.Backend.Application.DTOs;

namespace Knowledge.Backend.Application.Interfaces
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleDTO>> GetArticlesAsync();
        Task<ArticleDTO> GetArticleByIdAsync(int? id);
        Task<IEnumerable<ArticleDTO>> GetArticleByNameAsync(string? name);
        Task CreateArticleAsync(ArticleDTO articleDTO);
        Task UpdateArticleAsync(ArticleDTO articleDTO);
        Task DeleteArticleAsync(int? id);
    }
}
