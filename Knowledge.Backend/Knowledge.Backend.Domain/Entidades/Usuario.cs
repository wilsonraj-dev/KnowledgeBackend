namespace Knowledge.Backend.Domain.Entidades
{
    public class Usuario : Entidade
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public bool Admin { get; set; }
        public ICollection<Artigo>? Artigos { get; set; }
    }
}
