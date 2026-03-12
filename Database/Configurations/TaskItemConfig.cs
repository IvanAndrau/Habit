using HabitTracker.DataModels;
using HabitTracker.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Database.Configurations
{
    public class TaskItemConfig : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                .IsRequired();

            builder.Property(t => t.Description)
                .HasMaxLength(255);

            builder.Property(t => t.Priority)
                .HasConversion<string>()
                .HasDefaultValue(TaskPriority.None)
                .IsRequired();

            builder.Property(t => t.Difficulty)
                .HasConversion<string>()
                .HasDefaultValue(TaskDifficulty.None)
                .IsRequired();

            builder.Property(t => t.Category)
                .HasConversion<string>()
                .HasDefaultValue(TaskCategory.Other)
                .IsRequired();

            builder.Property(t => t.IsCompleted)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(t => t.PomodoroEnabled)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(t => t.ProgressEnabled)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(t => t.ProgressPercentage)
                .HasDefaultValue(0);

            builder.Property(t => t.CreatedAt)
                .HasDefaultValueSql("CURRENT_DATE");

            builder.Property(t => t.CreatedById)
                .IsRequired();

            builder.Property(t => t.TaskGroupId)
                .IsRequired();


            builder.HasOne(t => t.CreatedBy)
                .WithMany(u => u.CreatedTasks)
                .HasForeignKey(t => t.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.CompletedBy)
                .WithMany(u => u.CompletedTasks)
                .HasForeignKey(t => t.CompletedById)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.TaskGroup)
                .WithMany(tg => tg.Tasks)
                .HasForeignKey(t => t.TaskGroupId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
