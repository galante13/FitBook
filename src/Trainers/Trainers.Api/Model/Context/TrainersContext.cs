using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Trainers.Api.Model.Context
{
    public class TrainersContext : DbContext
    {
        public TrainersContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainer>()
                .OwnsOne(t => t.PersonalInfo);
        }

        protected TrainersContext()
        {
        }

        public DbSet<Diet> Diets { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealIngredient> MealIngredient { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
    }
}