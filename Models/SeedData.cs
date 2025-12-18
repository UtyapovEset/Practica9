namespace NormalPractica9.Models
{
    public class SeedData
    {
        public static void Initialize(TrainingDbContext context)
        {
            if (context.Roles.Any() || context.Gyms.Any() ||
                context.Clients.Any() || context.Coaches.Any())
            {
                return;
            }

            var roles = new Role[]
            {
                new Role { Name = "Client", Description = "Клиент спортивного зала" },
                new Role { Name = "Coach", Description = "Тренер/Инструктор" }
            };
            context.Roles.AddRange(roles);
            context.SaveChanges();

            var gyms = new Gym[]
            {
                new Gym {
                    Name = "Фитнес-центр \"Атлет\"",
                    Address = "ул. Спортивная, 15, Москва",
                    Phone = "+7 (495) 123-45-67"
                },
                new Gym {
                    Name = "Спорткомплекс \"Олимп\"",
                    Address = "пр. Победы, 42, Санкт-Петербург",
                    Phone = "+7 (812) 234-56-78"
                },
                new Gym {
                    Name = "Клуб \"Железный мир\"",
                    Address = "ул. Силовая, 7, Казань",
                    Phone = "+7 (843) 345-67-89"
                },
                new Gym {
                    Name = "Фитнес-студия \"Грация\"",
                    Address = "ул. Здоровья, 25, Екатеринбург",
                    Phone = "+7 (343) 456-78-90"
                },
                new Gym {
                    Name = "Тренажерный зал \"Титан\"",
                    Address = "ул. Мускульная, 33, Новосибирск",
                    Phone = "+7 (383) 567-89-01"
                }
            };
            context.Gyms.AddRange(gyms);
            context.SaveChanges();

            var clients = new Client[]
            {
                new Client {
                    FullName = "Иванов Алексей Сергеевич",
                    Age = 28,
                    Weight = 78.5m,
                    Height = 182.0m,
                    FitnessLevel = "Средний",
                    Phone = "+7 (910) 123-45-67",
                    Email = "alexei.ivanov@mail.ru",
                    RoleId = roles[0].Id
                },
                new Client {
                    FullName = "Петрова Мария Владимировна",
                    Age = 32,
                    Weight = 65.2m,
                    Height = 168.5m,
                    FitnessLevel = "Начинающий",
                    Phone = "+7 (911) 234-56-78",
                    Email = "maria.petrova@gmail.com",
                    RoleId = roles[0].Id
                },
                new Client {
                    FullName = "Сидоров Дмитрий Игоревич",
                    Age = 45,
                    Weight = 92.0m,
                    Height = 175.0m,
                    FitnessLevel = "Продвинутый",
                    Phone = "+7 (912) 345-67-89",
                    Email = "dmitry.sidorov@yandex.ru",
                    RoleId = roles[0].Id
                },
                new Client {
                    FullName = "Кузнецова Анна Петровна",
                    Age = 24,
                    Weight = 58.7m,
                    Height = 165.0m,
                    FitnessLevel = "Средний",
                    Phone = "+7 (913) 456-78-90",
                    Email = "anna.kuznetsova@mail.ru",
                    RoleId = roles[0].Id
                },
                new Client {
                    FullName = "Васильев Игорь Николаевич",
                    Age = 38,
                    Weight = 85.0m,
                    Height = 180.5m,
                    FitnessLevel = "Средний",
                    Phone = "+7 (914) 567-89-01",
                    Email = "igor.vasiliev@mail.ru",
                    RoleId = roles[0].Id
                }
            };
            context.Clients.AddRange(clients);
            context.SaveChanges();

            var coaches = new Coach[]
            {
                new Coach {
                    FullName = "Смирнов Александр Викторович",
                    Speciality = "Бодибилдинг",
                    ExperienceYears = 10,
                    Phone = "+7 (915) 678-90-12",
                    HourlyRate = 2500.00m,
                    RoleId = roles[1].Id,
                    GymId = gyms[0].Id
                },
                new Coach {
                    FullName = "Орлова Елена Дмитриевна",
                    Speciality = "Йога и стретчинг",
                    ExperienceYears = 7,
                    Phone = "+7 (916) 789-01-23",
                    HourlyRate = 2000.00m,
                    RoleId = roles[1].Id,
                    GymId = gyms[1].Id
                },
                new Coach {
                    FullName = "Козлов Сергей Андреевич",
                    Speciality = "Кроссфит",
                    ExperienceYears = 5,
                    Phone = "+7 (917) 890-12-34",
                    HourlyRate = 1800.00m,
                    RoleId = roles[1].Id,
                    GymId = gyms[2].Id
                },
                new Coach {
                    FullName = "Федорова Ольга Сергеевна",
                    Speciality = "Пилатес",
                    ExperienceYears = 8,
                    Phone = "+7 (918) 901-23-45",
                    HourlyRate = 2200.00m,
                    RoleId = roles[1].Id,
                    GymId = gyms[3].Id
                },
                new Coach {
                    FullName = "Николаев Павел Игоревич",
                    Speciality = "Пауэрлифтинг",
                    ExperienceYears = 12,
                    Phone = "+7 (919) 012-34-56",
                    HourlyRate = 3000.00m,
                    RoleId = roles[1].Id,
                    GymId = gyms[4].Id
                }
            };
            context.Coaches.AddRange(coaches);
            context.SaveChanges();

            var workouts = new Workout[]
            {
                new Workout {
                    WorkoutDate = DateTime.Now.AddDays(1),
                    DurationMinutes = 60,
                    Type = "Силовая тренировка",
                    Status = "Scheduled",
                    ClientId = clients[0].Id,
                    CoachId = coaches[0].Id
                },
                new Workout {
                    WorkoutDate = DateTime.Now.AddDays(2),
                    DurationMinutes = 90,
                    Type = "Йога",
                    Status = "Scheduled",
                    ClientId = clients[1].Id,
                    CoachId = coaches[1].Id
                },
                new Workout {
                    WorkoutDate = DateTime.Now.AddDays(1),
                    DurationMinutes = 75,
                    Type = "Кроссфит",
                    Status = "Scheduled",
                    ClientId = clients[2].Id,
                    CoachId = coaches[2].Id
                },
                new Workout {
                    WorkoutDate = DateTime.Now.AddHours(6),
                    DurationMinutes = 60,
                    Type = "Пилатес",
                    Status = "InProgress",
                    ClientId = clients[3].Id,
                    CoachId = coaches[3].Id
                },
                new Workout {
                    WorkoutDate = DateTime.Now.AddDays(-1),
                    DurationMinutes = 120,
                    Type = "Пауэрлифтинг",
                    Status = "Completed",
                    ClientId = clients[4].Id,
                    CoachId = coaches[4].Id
                }
            };
            context.Workouts.AddRange(workouts);
            context.SaveChanges();

            var exercises = new WorkoutExercise[]
            {
                new WorkoutExercise {
                    ExerciseName = "Жим штанги лежа",
                    Sets = 4,
                    Reps = 10,
                    Weight = 80.0m,
                    RestSeconds = 90,
                    WorkoutId = workouts[0].Id
                },
                new WorkoutExercise {
                    ExerciseName = "Приседания со штангой",
                    Sets = 3,
                    Reps = 12,
                    Weight = 60.0m,
                    RestSeconds = 120,
                    WorkoutId = workouts[0].Id
                },
                new WorkoutExercise {
                    ExerciseName = "Поза дерева (Врикшасана)",
                    Sets = 3,
                    Reps = 5,
                    Weight = 0,
                    RestSeconds = 30,
                    WorkoutId = workouts[1].Id
                },
                new WorkoutExercise {
                    ExerciseName = "Берпи",
                    Sets = 5,
                    Reps = 15,
                    Weight = 0,
                    RestSeconds = 60,
                    WorkoutId = workouts[2].Id
                },
                new WorkoutExercise {
                    ExerciseName = "Становая тяга",
                    Sets = 5,
                    Reps = 5,
                    Weight = 120.0m,
                    RestSeconds = 180,
                    WorkoutId = workouts[4].Id
                }
            };
            context.WorkoutExercises.AddRange(exercises);
            context.SaveChanges();
        }
    }
}