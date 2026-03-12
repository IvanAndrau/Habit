using HabitTracker.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Database.Configurations
{
    public class TaskProgressEventConfig : IEntityTypeConfiguration<TaskProgressEvent>
    {
        public void Configure(EntityTypeBuilder<TaskProgressEvent> builder)
        {
            builder.HasKey(tpe => tpe.Id);

            builder.Property(tpe => tpe.FromPercentage)
                .IsRequired();

            builder.Property(tpe => tpe.ToPercentage)
                .IsRequired();

            builder.Property(tpe => tpe.EventDate)
                .HasDefaultValueSql("now()")
                .IsRequired();

            builder.Property(tpe => tpe.TaskId)
                .IsRequired();

            builder.Property(tpe => tpe.UserId)
                .IsRequired();

            builder.HasOne(tpe => tpe.Task)
                .WithMany(t => t.ProgressEvents)
                .HasForeignKey(tpe => tpe.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(tpe => tpe.User)
                .WithMany()
                .HasForeignKey(tpe => tpe.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
