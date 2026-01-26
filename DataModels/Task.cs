using HabitTracker.Enums;

namespace HabitTracker.DataModels
{
    public class Task
    {
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }     //User ID of the task creator
        public string Title { get; set; }
        public string? Description { get; set; }
        public TaskPriority? Priority { get; set; }
        public TaskDifficulty? Difficulty { get; set; }
        public TaskCategory Category { get; set; }
        public Guid TaskGroupId { get; set; }
        public DateOnly? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public Guid? CompletedBy { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool PomodoroEnabled { get; set; }
        public bool ProgressEnabled { get; set; }
        public int? ProgressPercentage { get; set; }
        public DateOnly CreatedAt { get; set; }

        public ICollection<Pomodoro> Pomodoros { get; set; }
        public ICollection<TaskProgressEvent> TaskProgressEvents { get; set; }
        public TaskGroup TaskGroup { get; set; }
    }
}
