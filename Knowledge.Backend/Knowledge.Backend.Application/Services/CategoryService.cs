using AutoMapper;
using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Application.Interfaces;

namespace Knowledge.Backend.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }
        public Task<CategoryDTO> GetCategoryByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
        public Task CreateCategoryAsync(CategoryDTO category)
        {
            throw new NotImplementedException();
        }
        public Task UpdateCategoryAsync(CategoryDTO category)
        {
            throw new NotImplementedException();
        }
        public Task DeleteCategoryAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
