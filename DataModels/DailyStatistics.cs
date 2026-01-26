namespace HabitTracker.DataModels
{
    public class DailyStatistics
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateOnly Date { get; set; }
        public int HabitsScheduled { get; set; }
        public int HabitsCompleted { get; set; }
        public bool IsPerfectDay { get; set; }
    }
}
