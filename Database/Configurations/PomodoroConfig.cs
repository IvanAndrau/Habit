using HabitTracker.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Database.Configurations
{
    public class PomodoroConfig : IEntityTypeConfiguration<Pomodoro>
    {
        public void Configure(EntityTypeBuilder<Pomodoro> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.UserId)
                .IsRequired();

            builder.Property(p => p.TaskId)
                .IsRequired();

            builder.Property(p => p.SessionTime)
                .IsRequired()
                .HasDefaultValue(25);

            builder.Property(p => p.ShortBreak)
                .IsRequired()
                .HasDefaultValue(5);

            builder.Property(p => p.LongBreak)
                .IsRequired()
                .HasDefaultValue(15);

            builder.Property(p => p.SessionsCompleted)
                .IsRequired()
                .HasDefaultValue(0);


            builder.HasOne(p => p.User)
                .WithMany(u => u.Pomodoros)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // One-to-one — each task has at most one Pomodoro config
            builder.HasOne(p => p.Task)
                .WithOne(t => t.Pomodoro)
                .HasForeignKey<Pomodoro>(p => p.TaskId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
