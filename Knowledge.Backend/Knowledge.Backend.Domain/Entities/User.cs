using Knowledge.Backend.Domain.Validacao;

namespace Knowledge.Backend.Domain.Entidades
{
    public class User : Entity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Admin { get; set; } = false;
        public ICollection<Article>? Articles { get; set; }

        public User(string name, string email, string password, bool admin)
        {
            ValidateDomain(name, email, password, admin);
        }

        public User(int id, string name, string email, string password, bool admin)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");

            Id = id;
            ValidateDomain(name, email, password, admin);
        }

        private void ValidateDomain(string name, string email, string password, bool admin)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required.");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, too short, minimum 3 characters.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Invalid email. Email is required.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(password), "Invalid password. Password is required.");
            DomainExceptionValidation.When(password.Length < 7, "Invalid password, too short, minimum 3 characters.");

            Name = name;
            Email = email;
            Password = password;
            Admin = admin;
        }
    }
}
