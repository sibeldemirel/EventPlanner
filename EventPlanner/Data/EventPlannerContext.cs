using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventPlanner.Models;

namespace EventPlanner.Data
{
    public class EventPlannerContext : DbContext
    {
        public EventPlannerContext (DbContextOptions<EventPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<EventPlanner.Models.Participant> Participant { get; set; } = default!;
        public DbSet<EventPlanner.Models.Event> Event { get; set; } = default!;
        public DbSet<EventPlanner.Models.Agent> Agent { get; set; } = default!;
    }
}
