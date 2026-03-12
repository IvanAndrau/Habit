using Microsoft.AspNetCore.Identity;

namespace HabitTracker.DataModels
{
    public class ApplicationUser : IdentityUser
    {
        public string Color { get; set; } = null!;

        public ICollection<Habit> Habits { get; set; } = [];
        public ICollection<HabitCompletion> HabitCompletions { get; set; } = [];
        public ICollection<TaskItem> CreatedTasks { get; set; } = [];
        public ICollection<TaskItem> CompletedTasks { get; set; } = [];
        public ICollection<TaskGroup> CreatedTaskGroups { get; set; } = [];
        public ICollection<TaskGroupMember> TaskGroupMemberships { get; set; } = [];
        public ICollection<Pomodoro> Pomodoros { get; set; } = [];
        public ICollection<Friendship> SentFriendRequests { get; set; } = [];
        public ICollection<Friendship> ReceivedFriendRequests { get; set; } = [];
        public ICollection<DailyStatistics> DailyStatistics { get; set; } = [];
        public ICollection<WeeklyStatistics> WeeklyStatistics { get; set; } = [];
        public ICollection<MonthlyStatistics> MonthlyStatistics { get; set; } = [];
        public ICollection<YearlyStatistics> YearlyStatistics { get; set; } = [];
    }
}
