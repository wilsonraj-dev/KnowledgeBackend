namespace Knowledge.Backend.Domain.Entidades
{
    public class User : Entity
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public bool Admin { get; set; }
        public ICollection<Article>? Artigos { get; set; }
    }
}
