using NormalPractica9.Models;

namespace NormalPractica9.IRepository
{
    public interface IWorkoutRepository
    {
        Task<IEnumerable<Workout>> GetByClientIdAsync(int clientId);
        Task<IEnumerable<Workout>> GetByCoachIdAsync(int coachId);
        Task<IEnumerable<Workout>> GetByStatusAsync(string status);
    }
}
