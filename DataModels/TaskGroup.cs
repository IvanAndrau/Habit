namespace HabitTracker.DataModels
{
    public class TaskGroup
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public Guid CreatedBy { get; set; }     //User ID of the task group owner

        public ICollection<TaskItem> Tasks { get; set; }
        public ICollection<TaskGroupMember> Members { get; set; }
    }
}
