
namespace EventPlanner.Models
{
    public class Participant
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string Password { get; set; }
        public required int Age { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required string Role { get; set; }
    }
}
