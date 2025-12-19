using Microsoft.EntityFrameworkCore;
using NormalPractica9.IRepository;
using NormalPractica9.Models;


namespace NormalPractica9.Repository
{
    public class GymRepository : IGymRepository
    {
        private readonly TrainingDbContext _context;

        public GymRepository(TrainingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Gym>> GetAllAsync()
        {
            return await _context.Gyms.ToListAsync();
        }

        public async Task<Gym?> GetByIdAsync(int id)
        {
            return await _context.Gyms.FindAsync(id);
        }

        public async Task AddAsync(Gym entity)
        {
            _context.Gyms.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Gym entity)
        {
            _context.Gyms.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var gym = await _context.Gyms.FindAsync(id);
            if (gym != null)
            {
                _context.Gyms.Remove(gym);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Gym>> GetWithCoachesAsync()
        {
            return await _context.Gyms
                .Include(g => g.Coaches)
                .ToListAsync();
        }

        public async Task<Gym?> GetByNameAsync(string name)
        {
            return await _context.Gyms
                .FirstOrDefaultAsync(g => g.Name == name);
        }

        public async Task<IEnumerable<Gym>> GetByCityAsync(string city)
        {
            return await _context.Gyms
                .Where(g => g.Address.Contains(city))
                .ToListAsync();
        }
    }
}
