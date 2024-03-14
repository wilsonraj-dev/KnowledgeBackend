using AutoMapper;
using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Application.Interfaces;
using Knowledge.Backend.Domain.Entidades;
using Knowledge.Backend.Domain.Interfaces;

namespace Knowledge.Backend.Application.Services
{
    public class ArticleService : IArticleService
    {
        private IArticleRepository _articleRepository;
        private readonly IMapper _mapper;

        public ArticleService(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ArticleDTO>> GetArticlesDTOAsync()
        {
            var articles = await _articleRepository.GetArticlesAsync();
            return _mapper.Map<IEnumerable<ArticleDTO>>(articles);
        }

        public async Task<ArticleDTO> GetArticleDTOByIdAsync(int? id)
        {
            var article = await _articleRepository.GetArticleByIdAsync(id);
            return _mapper.Map<ArticleDTO>(article);
        }

        public async Task<IEnumerable<ArticleDTO>> GetArticleDTOByNameAsync(string? name)
        {
            var articles = await _articleRepository.GetArticlesByNameAsync(name);
            return _mapper.Map<IEnumerable<ArticleDTO>>(articles);
        }

        public async Task CreateArticleDTOAsync(ArticleDTO articleDTO)
        {
            var articleEntity = _mapper.Map<Article>(articleDTO);
            await _articleRepository.CreateArticleAsync(articleEntity);
        }

        public async Task UpdateArticleDTOAsync(ArticleDTO articleDTO)
        {
            var articleEntity = _mapper.Map<Article>(articleDTO);
            await _articleRepository.UpdateArticleAsync(articleEntity);
        }

        public async Task DeleteArticleDTOAsync(int? id)
        {
            var articleEntity = _articleRepository.GetArticleByIdAsync(id).Result;
            await _articleRepository.DeleteArticleAsync(articleEntity).ConfigureAwait(false);
        }
    }
}
