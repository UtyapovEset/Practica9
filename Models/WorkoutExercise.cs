namespace NormalPractica9.Models
{
    public class WorkoutExercise
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public decimal Weight { get; set; }
        public int RestSeconds { get; set; }

        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
    }
}
