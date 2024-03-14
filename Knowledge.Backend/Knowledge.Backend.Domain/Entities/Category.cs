using Knowledge.Backend.Domain.Validacao;

namespace Knowledge.Backend.Domain.Entidades
{
    public class Category : Entity
    {
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public ICollection<Category>? SubCategories { get; set; }
        public ICollection<Article>? Articles { get; set; }

        public Category() { }

        public Category(string name, int categoryId)
        {
            CreateTime = DateTime.Now;
            ValidateDomain(name, categoryId);
        }

        public Category(int id, string name, int categoryId)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");

            Id = id;
            ValidateDomain(name, categoryId);
        }

        private void ValidateDomain(string name, int categoryId)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required.");

            Name = name;
            CategoryId = categoryId;
            UpdateTime = DateTime.Now;
        }
    }
}
