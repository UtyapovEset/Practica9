using Microsoft.EntityFrameworkCore;
using NormalPractica9.IRepository;
using NormalPractica9.Models;

namespace NormalPractica9.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly TrainingDbContext _context;

        public ClientRepository(TrainingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client?> GetByIdAsync(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task AddAsync(Client entity)
        {
            _context.Clients.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Client entity)
        {
            _context.Clients.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
        }
    
        public async Task<IEnumerable<Client>> GetByFitnessLevelAsync(string level)
        {
            return await _context.Clients
                .Where(c => c.FitnessLevel == level)
                .ToListAsync();
        }

        public async Task<IEnumerable<Client>> GetByAgeAsync(int age)
        {
            return await _context.Clients
                .Where(c => c.Age == age)
                .ToListAsync();
        }

        public async Task<Client?> GetByEmailAsync(string email)
        {
            return await _context.Clients
                .FirstOrDefaultAsync(c => c.Email == email);
        }
    }
}