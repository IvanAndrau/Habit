using HabitTracker.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;

namespace HabitTracker.Database
{
    public class HabitTrackerDbContext : IdentityDbContext
    {
        public HabitTrackerDbContext(DbContextOptions<HabitTrackerDbContext> options) : base(options) { }

        public DbSet<DailyStatistics> DailyStatistics { get; set; }
        public DbSet<WeeklyStatistics> WeeklyStatistics { get; set; }
        public DbSet<MonthlyStatistics> MonthlyStatistics { get; set; }
        public DbSet<YearlyStatistics> YearlyStatistics { get; set; }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<HabitCompletion> HabitCompletions { get; set; }
        public DbSet<HabitSchedule> HabitSchedules { get; set; }
        public DbSet<Pomodoro> Pomodors { get; set; }
        public DbSet<DataModels.Task> Tasks { get; set; }
        public DbSet<TaskGroup> TaskGroups { get; set; }
        public DbSet<TaskGroupMember> TaskGroupMembers { get; set; }
        public DbSet<TaskProgressEvent> TaskProgressEvents { get; set; }
        public DbSet<Friendship> Friendships { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // runs all Config files setting up entities
        }
    }
}
