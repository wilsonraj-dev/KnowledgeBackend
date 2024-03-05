namespace Knowledge.Backend.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ParentId { get; set; }
        public int? CategoryId { get; set; }
    }
}
