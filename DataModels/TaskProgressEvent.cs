namespace Habit.DataModels
{
    public class TaskProgressEvent
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Guid UserId { get; set; }
        public int FromPercentage { get; set; }
        public int ToPercentage { get; set; }
        public DateTime EventDate { get; set; }

        public Task Task { get; set; }
    }
}
