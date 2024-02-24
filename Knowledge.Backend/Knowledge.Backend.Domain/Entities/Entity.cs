namespace Knowledge.Backend.Domain.Entidades
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UserSign { get; set; }
    }
}
