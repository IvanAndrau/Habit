namespace HabitTracker.DataModels
{
    public class TaskGroup
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Icon { get; set; } = null!;
        public Guid CreatedById { get; set; }     //User ID of the task group owner

        public ApplicationUser CreatedBy { get; set; } = null!;
        public ICollection<TaskItem> Tasks { get; set; } = [];
        public ICollection<TaskGroupMember> Members { get; set; } = [];
    }
}
