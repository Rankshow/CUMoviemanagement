namespace MovieManagement.Domain.Entity
{
    public class Biography
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int ActorId { get; set; }
        public Actor? Actor { get; set; }
    }
}