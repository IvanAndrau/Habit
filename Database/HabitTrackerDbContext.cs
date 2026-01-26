using HabitTracker.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Database
{
    public class HabitTrackerDbContext : IdentityDbContext
    {
        public HabitTrackerDbContext(DbContextOptions<HabitTrackerDbContext> options) : base(options) { }

        public DbSet<DailyStatistics> DailyStatistics { get; set; }
        public DbSet<WeeklyStatistics> WeeklyStatistics { get; set; }
        public DbSet<MonthlyStatistics> MonthlyStatistics { get; set; }
        public DbSet<EarlyStatistics> EarlyStatistics { get; set; }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<HabitCompletion> HabitCompletions { get; set; }
        public DbSet<HabitSchedule> HabitSchedules { get; set; }
        public DbSet<Pomodoro> Pomodors { get; set; }
        public DbSet<DataModels.Task> Tasks { get; set; }
        public DbSet<TaskGroup> TaskGroups { get; set; }
        public DbSet<TaskGroupMember> TaskGroupMembers { get; set; }
        public DbSet<TaskProgressEvent> TaskProgressEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<HabitSchedule>()
            //    .HasKey(hs => new { hs.HabitId, hs.DayOfWeek });
            //builder.Entity<TaskGroupMember>()
            //    .HasKey(tgm => new { tgm.TaskGroupId, tgm.UserId });


        }
    }
}
