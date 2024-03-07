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

        public async Task<IEnumerable<ArticleDTO>> GetArticlesAsync()
        {
            var articles = await _articleRepository.GetArticlesAsync();
            return _mapper.Map<IEnumerable<ArticleDTO>>(articles);
        }

        public async Task<ArticleDTO> GetArticleByIdAsync(int? id)
        {
            var article = await _articleRepository.GetArticleByIdAsync(id);
            return _mapper.Map<ArticleDTO>(article);
        }

        public async Task<IEnumerable<ArticleDTO>> GetArticleByNameAsync(string? name)
        {
            var articles = await _articleRepository.GetArticlesByNameAsync(name);
            return _mapper.Map<IEnumerable<ArticleDTO>>(articles);
        }

        public async Task CreateArticleAsync(ArticleDTO articleDTO)
        {
            var articleEntity = _mapper.Map<Article>(articleDTO);
            await _articleRepository.CreateArticleAsync(articleEntity);
        }

        public async Task UpdateArticleAsync(ArticleDTO articleDTO)
        {
            var articleEntity = _mapper.Map<Article>(articleDTO);
            await _articleRepository.UpdateArticleAsync(articleEntity);
        }

        public async Task DeleteArticleAsync(int? id)
        {
            var articleEntity = _articleRepository.GetArticleByIdAsync(id).Result;
            await _articleRepository.DeleteArticleAsync(articleEntity).ConfigureAwait(false);
        }
    }
}
