using NormalPractica9.Models;

namespace NormalPractica9.IRepository
{
    public interface ICoachRepository : IRepository<Coach>
    {
        Task<IEnumerable<Coach>> GetBySpecialityAsync(string speciality);
        Task<IEnumerable<Coach>> GetByExperienceAsync(int years);
        Task<IEnumerable<Coach>> GetByGymIdAsync(int gymId);
    }
}
