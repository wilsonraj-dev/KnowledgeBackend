namespace Knowledge.Backend.Application.DTOs
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Content { get; set; }
        public int UserId { get; set; }
        public UserDTO? UserDTO { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO? CategoryDTO { get; set; }
    }
}
