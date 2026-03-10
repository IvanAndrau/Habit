using HabitTracker.Enums;

namespace HabitTracker.DataModels
{
    public class Habit
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Icon { get; set; } = null!;
        public string Color { get; set; } = null!;
        public HabitFrequency FrequencyType { get; set; }    //Daily, Weekly
        public int CurrentStreak { get; set; }
        public int BestStreak { get; set; }

        public ApplicationUser User { get; set; } = null!;
        public ICollection<HabitSchedule> HabitSchedules { get; set; } = [];
        public ICollection<HabitCompletion> HabitCompletions { get; set; } = [];
    }
}
