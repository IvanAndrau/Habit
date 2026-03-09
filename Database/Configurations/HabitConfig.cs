using HabitTracker.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Database.Configurations
{
    public class HabitConfig : IEntityTypeConfiguration<Habit>
    {
        public void Configure(EntityTypeBuilder<Habit> builder)
        {

            builder.HasKey(h => h.Id);

            builder.Property(h => h.UserId)
                .IsRequired();

            builder.Property(h => h.Title)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(h => h.Title)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(h => h.Color)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(h => h.FrequencyType)
                .HasConversion<string>()   // stores "Daily"/"Weekly" in DB
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(h => h.CurrentStreak)
                .HasDefaultValue(0);

            builder.Property(h => h.BestStreak)
                .HasDefaultValue(0);

            builder.HasOne(u => u.User)
                .WithMany(h => h.Habits)
                .HasForeignKey(h => h.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
