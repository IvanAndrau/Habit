namespace HabitTracker.DataModels
{
    public class MonthlyStatistics
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; } // 1-12 for January to December
        public int HabitsCompleted { get; set; }
        public int TasksCompleted { get; set; }
        public int PomodorosCompleted { get; set; }
        public bool IsPerfectMonth { get; set; }
    }
}
