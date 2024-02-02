namespace Knowledge.Backend.Domain.Entidades
{
    public class Category : Entity
    {
        public string? Nome { get; set; }
        public int ParentId { get; set; }
        public ICollection<Article>? Artigos { get; set; }
    }
}
