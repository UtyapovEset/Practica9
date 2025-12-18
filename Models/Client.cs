using System.Data;

namespace NormalPractica9.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string FitnessLevel { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; } = null!;

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
