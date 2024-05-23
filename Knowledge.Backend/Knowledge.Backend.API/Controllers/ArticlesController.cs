using Knowledge.Backend.Application.DTOs;
using Knowledge.Backend.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Knowledge.Backend.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ArticleDTO>>> GetAllArticles()
        {
            var articles = await _articleService.GetArticlesDTOAsync();

            if (articles == null)
            {
                return NotFound("No articles found");
            }

            return Ok(articles);
        }

        [HttpGet]
        [Route("ArticleById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserDTO>> GetArticleById(int id)
        {
            var article = await _articleService.GetArticleDTOByIdAsync(id);

            if (article.Id != id)
            {
                return BadRequest($"Article {id} not found.");
            }
            else if (article == null)
            {
                return NotFound("No article found.");
            }

            return Ok(article);
        }

        [HttpGet]
        //[Route("ArticlesByCategory/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetArticlesByCategory([FromHeader(Name = "X-User-Id")] int userId)
        {
            var articles = await _articleService.GetArticlesDTOByCategoryAsync(userId);

            if (articles == null)
            {
                return Ok("");
            }

            return Ok(articles);
        }
    }
}
