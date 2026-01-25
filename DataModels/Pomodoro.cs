namespace Habit.DataModels
{
    public class Pomodoro
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid TaskId { get; set; }
        public int SessionTime { get; set; } = 25;
        public int ShortBreak { get; set; } = 5;
        public int LongBreak { get; set; } = 15;
        public int SessionsCompleted { get; set; } = 0;

        public Task Task { get; set; }
    }
}
