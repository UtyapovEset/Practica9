using Microsoft.EntityFrameworkCore;
using NormalPractica9.IRepository;
using NormalPractica9.Models;

namespace NormalPractica9.Repository
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private readonly TrainingDbContext _context;

        public WorkoutRepository(TrainingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Workout>> GetAllAsync()
        {
            return await _context.Workouts.ToListAsync();
        }

        public async Task<Workout?> GetByIdAsync(int id)
        {
            return await _context.Workouts.FindAsync(id);
        }

        public async Task AddAsync(Workout entity)
        {
            _context.Workouts.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Workout entity)
        {
            _context.Workouts.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var workout = await _context.Workouts.FindAsync(id);
            if (workout != null)
            {
                _context.Workouts.Remove(workout);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Workout>> GetByClientIdAsync(int clientId)
        {
            return await _context.Workouts
                .Where(w => w.ClientId == clientId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Workout>> GetByCoachIdAsync(int coachId)
        {
            return await _context.Workouts
                .Where(w => w.CoachId == coachId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Workout>> GetByStatusAsync(string status)
        {
            return await _context.Workouts
                .Where(w => w.Status == status)
                .ToListAsync();
        }
    }
}