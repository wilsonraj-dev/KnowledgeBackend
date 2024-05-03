namespace Knowledge.Backend.Application.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool Admin { get; set; } = false;
    }

    public class UserWithPasswordDTO : UserDTO
    {
        public string? Password { get; set; }
    }
}
