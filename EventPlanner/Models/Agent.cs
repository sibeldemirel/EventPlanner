namespace EventPlanner.Models
{
    public class Agent
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string MotDePasse { get; set; }
        public required string role { get; set; }
    }
}
