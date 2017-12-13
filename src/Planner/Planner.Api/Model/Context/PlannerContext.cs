using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Planner.Api.Model.Context
{
    public class PlannerContext : DbContext
    {
        public PlannerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TrainingPlan> TrainingPlans { get; set; }
    }
}