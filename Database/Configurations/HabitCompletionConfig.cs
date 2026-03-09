using HabitTracker.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Database.Configurations
{
    public class HabitCompletionConfig : IEntityTypeConfiguration<HabitCompletion>
    {
        public void Configure(EntityTypeBuilder<HabitCompletion> builder)
        {
            builder.ToTable("habit_completion");

            builder.HasKey(hc => hc.Id);

            builder.Property(hc => hc.Id)
                .HasColumnName("id");

            builder.Property(hc => hc.HabitId)
                .HasColumnName("habit_id")
                .IsRequired();

            builder.Property(hc => hc.UserId)
                .HasColumnName("user_id")
                .IsRequired();

            builder.Property(hc => hc.CompletedAt)
                .HasColumnName("completed_at")
                .IsRequired();

            // Relationship: HabitCompletion → Habit
            builder.HasOne(hc => hc.Habit)
                .WithMany(h => h.HabitCompletions)
                .HasForeignKey(hc => hc.HabitId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relationship: HabitCompletion → ApplicationUser
            builder.HasOne(hc => hc.User)
                .WithMany(u => u.HabitCompletions)
                .HasForeignKey(hc => hc.UserId)
                .OnDelete(DeleteBehavior.Restrict); // don't delete completions if user deleted
        }
    }
}
