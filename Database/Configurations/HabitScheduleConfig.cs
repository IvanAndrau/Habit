using HabitTracker.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Database.Configurations
{
    public class HabitScheduleConfig : IEntityTypeConfiguration<HabitSchedule>
    {
        public void Configure(EntityTypeBuilder<HabitSchedule> builder)
        {
            builder.HasKey(hs => new { hs.HabitId, hs.DayOfWeek }); //composite PK

            builder.Property(hs => hs.HabitId)
                .IsRequired();

            builder.Property(hs => hs.DayOfWeek)
                .HasConversion<string>()  // stores "Monday", "Tuesday" etc.
                .HasMaxLength(20)
                .IsRequired();

            // Relationship: HabitSchedule → Habit
            builder.HasOne(hs => hs.Habit)
                .WithMany(h => h.HabitSchedules)
                .HasForeignKey(hs => hs.HabitId)
                .OnDelete(DeleteBehavior.Cascade);  // delete schedules when habit deleted
        }
    }
}
