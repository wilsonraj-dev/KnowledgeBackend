using Knowledge.Backend.Application.DTOs;
namespace Knowledge.Backend.Application.Interfaces
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleDTO>> GetArticlesDTOAsync();
        Task<ArticleDTO> GetArticleDTOByIdAsync(int? id);
        Task<IEnumerable<ArticleDTO>> GetArticlesDTOByCategoryAsync(int idCategory);
        Task<IEnumerable<ArticleDTO>> GetArticleDTOByNameAsync(string? name);
        Task CreateArticleDTOAsync(ArticleDTO articleDTO);
        Task UpdateArticleDTOAsync(ArticleDTO articleDTO);
        Task DeleteArticleDTOAsync(int? id);
    }
}
