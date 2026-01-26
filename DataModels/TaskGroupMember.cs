namespace HabitTracker.DataModels
{
    public class TaskGroupMember
    {
        public Guid Id { get; set; }
        public Guid TaskGroupId { get; set; }
        public Guid UserId { get; set; }
        public DateOnly JoinedAt { get; set; }

        public TaskGroup TaskGroup { get; set; }
    }
}
