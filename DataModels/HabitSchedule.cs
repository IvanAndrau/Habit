namespace HabitTracker.DataModels
{
    public class HabitSchedule
    {
        public Guid Id { get; set; }
        public Guid HabitId { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public Habit Habit { get; set; }
    }
}
