namespace Habit.DataModels
{
    public class HabitCompletion
    {
        public Guid Id { get; set; }
        public Guid HabitId { get; set; }
        public Guid UserId { get; set; }
        public DateOnly CompletedAt { get; set; }
        public Habit Habit { get; set; }
    }
}
