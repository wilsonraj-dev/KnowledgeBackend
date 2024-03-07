﻿using Knowledge.Backend.Application.DTOs;

namespace Knowledge.Backend.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
        Task<CategoryDTO> GetCategoryByIdAsync(int? id);
        Task CreateCategoryAsync(CategoryDTO categoryDTO);
        Task UpdateCategoryAsync(CategoryDTO categoryDTO);
        Task DeleteCategoryAsync(int? id);
    }
}
