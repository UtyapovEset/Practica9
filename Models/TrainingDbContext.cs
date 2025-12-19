using Microsoft.EntityFrameworkCore;

namespace NormalPractica9.Models
{
    public class TrainingDbContext : DbContext
    {
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Role> Roles { get; set; }


        public TrainingDbContext(DbContextOptions<TrainingDbContext> options) : base(options) { }
    }
}
