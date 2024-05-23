using Knowledge.Backend.Domain.Validacao;

namespace Knowledge.Backend.Domain.Entidades
{
    public class Article : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Content { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public Article(string name, string description, string imageUrl, string content)
        {
            CreateTime = DateTime.Now;
            ValidateDomain(name, description, imageUrl, content);
        }

        public Article(int id, string name, string description, string imageUrl, string content)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");

            Id = id;
            ValidateDomain(name, description, imageUrl, content);
        }

        private void ValidateDomain(string name, string description, string imageUrl, string content)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required.");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, too short, minimum 3 characters.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description. Description is required.");
            DomainExceptionValidation.When(description.Length < 5, "Invalid description, too short, minimum 5 characters.");
            DomainExceptionValidation.When(imageUrl?.Length > 1000, "Invalid image name, too long, maximum 1000 characters.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(content), "Invalid content. Content is required.");

            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            Content = content;
            UpdateTime = DateTime.Now;
        }
    }
}
