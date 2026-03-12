using HabitTracker.Enums;

namespace HabitTracker.DataModels
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public Guid CreatedById { get; set; }     //User ID of the task creator
        public string Title { get; set; }
        public string? Description { get; set; }
        public TaskPriority Priority { get; set; } = TaskPriority.None;
        public TaskDifficulty Difficulty { get; set; } = TaskDifficulty.None;
        public TaskCategory Category { get; set; }
        public Guid TaskGroupId { get; set; }
        public DateOnly? DueDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public Guid? CompletedById { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool PomodoroEnabled { get; set; } = false;
        public bool ProgressEnabled { get; set; } = false;
        public int? ProgressPercentage { get; set; }
        public DateOnly CreatedAt { get; set; }

        public ApplicationUser CreatedBy { get; set; } = null!;
        public ApplicationUser? CompletedBy { get; set; }
        public ICollection<Pomodoro> Pomodoros { get; set; }
        public ICollection<TaskProgressEvent> TaskProgressEvents { get; set; } = [];
        public TaskGroup TaskGroup { get; set; }
    }
}
