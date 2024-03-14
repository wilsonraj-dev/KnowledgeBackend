using AutoMapper;
using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Application.Interfaces;
using Knowledge.Backend.Domain.Entidades;
using Knowledge.Backend.Domain.Interfaces;

namespace Knowledge.Backend.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesDTOAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

        public async Task<CategoryDTO> GetCategoryDTOByIdAsync(int? id)
        {
            var category = await _categoryRepository.GetCategoryByIdAsync(id);
            return _mapper.Map<CategoryDTO>(category);
        }

        public async Task CreateCategoryDTOAsync(CategoryDTO categoryDTO)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.CreateCategoryAsync(categoryEntity);
        }

        public async Task UpdateCategoryDTOAsync(CategoryDTO categoryDTO)
        {
            var categoryEntity = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.UpdateCategoryAsync(categoryEntity);
        }

        public async Task DeleteCategoryDTOAsync(int? id)
        {
            var categoryEntity = _categoryRepository.GetCategoryByIdAsync(id).Result;
            await _categoryRepository.DeleteCategoryAsync(categoryEntity).ConfigureAwait(false);
        }
    }
}
