namespace HabitTracker.DataModels
{
    public class EarlyStatistics
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Year { get; set; }
        public int HabitsCompleted { get; set; }
        public int TasksCompleted { get; set; }
        public int PomodorosCompleted { get; set; }
        public bool IsPerfectDay { get; set; }
    }
}
