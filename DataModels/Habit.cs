using HabitTracker.Enums;

namespace HabitTracker.DataModels
{
    public class Habit
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public HabitFrequency FrequencyType { get; set; }    //Daily, Weekly
        public int CurrentStreak { get; set; }
        public int BestStreak { get; set; }

        public ICollection<HabitSchedule> HabitSchedule { get; set; }
        public ICollection<HabitCompletion> HabitCompletions { get; set; }
    }
}
