using Knowledge.Backend.Domain.Validacao;

namespace Knowledge.Backend.Domain.Entidades
{
    public class Category : Entity
    {
        public string? Name { get; set; }
        public int ParentId { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Category> SubCategories { get; set; }
        public ICollection<Article>? Articles { get; set; }

        public Category(string name, int parentId)
        {
            CreateTime = DateTime.Now;
            ValidateDomain(name, parentId);
        }

        public Category(int id, string name, int parentId)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");

            Id = id;
            ValidateDomain(name, parentId);
        }

        private void ValidateDomain(string name, int parentId)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required.");

            Name = name;
            ParentId = parentId;
            UpdateTime = DateTime.Now;
        }
    }
}
