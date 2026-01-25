namespace Habit.DataModels
{
    public class WeeklyStatistics
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Year { get; set; }
        public int ISOWeekNumber { get; set; } // ISO 8601 week number (52-53 weeks per year)
        public int HabitsCompleted { get; set; }
        public int TasksCompleted { get; set; }
        public int PomodorosCompleted { get; set; }
        public bool IsPerfectWeek { get; set; }
    }
}
