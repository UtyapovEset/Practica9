namespace NormalPractica9.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime WorkoutDate { get; set; }
        public int DurationMinutes { get; set; } = 60;
        public string Type { get; set; }
        public string Status { get; set; } = "Scheduled";

        public int ClientId { get; set; }
        public int CoachId { get; set; }

        public Client Client { get; set; }
        public Coach Coach { get; set; }
        public ICollection<WorkoutExercise> Exercises { get; set; }
    }
}
