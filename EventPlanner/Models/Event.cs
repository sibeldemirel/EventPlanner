﻿namespace EventPlanner.Models
{
    public class Event
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required DateTime Date { get; set; }
        public required string Place { get; set; }
        public required string Description { get; set; }
        public required string Image { get; set; }
        public required int Price { get; set; }
        public required List <Participant> participants { get; set; }
    }
}
