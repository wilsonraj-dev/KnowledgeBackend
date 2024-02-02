namespace Knowledge.Backend.Domain.Entidades
{
    public class Artigo : Entidade
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? UrlImagem { get; set; }
        public string? Conteudo { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
