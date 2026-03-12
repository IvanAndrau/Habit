using HabitTracker.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Database.Configurations
{
    public class TaskGroupConfig : IEntityTypeConfiguration<TaskGroup>
    {
        public void Configure(EntityTypeBuilder<TaskGroup> builder)
        {

            builder.HasKey(tg => tg.Id);

            builder.Property(tg => tg.Title)
                .HasMaxLength(64)
                .IsRequired();

            builder.Property(tg => tg.Color)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(tg => tg.Icon)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(tg => tg.CreatedById)
                .IsRequired();

            builder.HasOne(tg => tg.CreatedBy)
                .WithMany(u => u.CreatedTaskGroups)
                .HasForeignKey(tg => tg.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
