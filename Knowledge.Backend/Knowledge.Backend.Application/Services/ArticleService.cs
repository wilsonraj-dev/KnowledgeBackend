using AutoMapper;
using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Application.Interfaces;

namespace Knowledge.Backend.Application.Services
{
    public class ArticleService : IArticleService
    {
        private IArticleService _articleService;
        private readonly IMapper _mapper;

        public ArticleService(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public Task<IEnumerable<ArticleDTO>> GetArticlesAsync()
        {
            throw new NotImplementedException();
        }
        public Task<ArticleDTO> GetArticleByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
        public Task<ArticleDTO> GetArticleByNameAsync(string? name)
        {
            throw new NotImplementedException();
        }
        public Task CreateArticleAsync(ArticleDTO article)
        {
            throw new NotImplementedException();
        }
        public Task UpdateArticleAsync(ArticleDTO article)
        {
            throw new NotImplementedException();
        }
        public Task DeleteArticleAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
