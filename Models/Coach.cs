namespace NormalPractica9.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Speciality { get; set; }
        public int ExperienceYears { get; set; }
        public string Phone { get; set; }
        public decimal HourlyRate { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int GymId { get; set; }
        public Gym Gym { get; set; }
    }
}
