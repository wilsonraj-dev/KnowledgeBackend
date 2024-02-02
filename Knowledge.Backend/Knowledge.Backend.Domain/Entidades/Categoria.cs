namespace Knowledge.Backend.Domain.Entidades
{
    public class Categoria : Entidade
    {
        public string? Nome { get; set; }
        public int ParentId { get; set; }
        public ICollection<Artigo>? Artigos { get; set; }
    }
}
