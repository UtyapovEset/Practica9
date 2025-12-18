namespace NormalPractica9.Models
{
    public class Gym
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICollection<Coach> Coaches { get; set; }
    }
}
