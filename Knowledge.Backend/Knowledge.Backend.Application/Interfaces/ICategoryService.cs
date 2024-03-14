using Knowledge.Backend.Application.DTOs;

namespace Knowledge.Backend.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategoriesDTOAsync();
        Task<CategoryDTO> GetCategoryDTOByIdAsync(int? id);
        Task CreateCategoryDTOAsync(CategoryDTO categoryDTO);
        Task UpdateCategoryDTOAsync(CategoryDTO categoryDTO);
        Task DeleteCategoryDTOAsync(int? id);
    }
}
