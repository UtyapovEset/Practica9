using NormalPractica9.IRepository;
using NormalPractica9.Models;
using Microsoft.EntityFrameworkCore;


namespace NormalPractica9.Repository
{
    public class CoachRepository : ICoachRepository
    {
        private readonly TrainingDbContext _context;

        public CoachRepository(TrainingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Coach>> GetAllAsync()
        {
            return await _context.Coaches.ToListAsync();
        }

        public async Task<Coach?> GetByIdAsync(int id)
        {
            return await _context.Coaches.FindAsync(id);
        }

        public async Task AddAsync(Coach entity)
        {
            _context.Coaches.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Coach entity)
        {
            _context.Coaches.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var coach = await _context.Coaches.FindAsync(id);
            if (coach != null)
            {
                _context.Coaches.Remove(coach);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Coach>> GetBySpecialityAsync(string speciality)
        {
            return await _context.Coaches
                .Where(c => c.Speciality == speciality)
                .ToListAsync();
        }

        public async Task<IEnumerable<Coach>> GetByExperienceAsync(int years)
        {
            return await _context.Coaches
                .Where(c => c.ExperienceYears >= years)
                .ToListAsync();
        }

        public async Task<IEnumerable<Coach>> GetByGymIdAsync(int gymId)
        {
            return await _context.Coaches
                .Where(c => c.GymId == gymId)
                .ToListAsync();
        }
    }
}