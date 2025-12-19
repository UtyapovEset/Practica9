using NormalPractica9.Models;

namespace NormalPractica9.IRepository
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<IEnumerable<Client>> GetByFitnessLevelAsync(string level);
        Task<IEnumerable<Client>> GetByAgeAsync(int age);
        Task<Client?> GetByEmailAsync(string email);
    }
}
