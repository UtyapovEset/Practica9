using NormalPractica9.Models;

namespace NormalPractica9.IRepository
{
    public interface IGymRepository : IRepository<Gym>
    {
        Task<IEnumerable<Gym>> GetWithCoachesAsync();
        Task<Gym?> GetByNameAsync(string name);
        Task<IEnumerable<Gym>> GetByCityAsync(string city);
    }
}
