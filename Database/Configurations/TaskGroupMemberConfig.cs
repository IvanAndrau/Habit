using HabitTracker.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Database.Configurations
{
    public class TaskGroupMemberConfig : IEntityTypeConfiguration<TaskGroupMember>
    {
        public void Configure(EntityTypeBuilder<TaskGroupMember> builder)
        {
            builder.HasKey(tgm => new { tgm.TaskGroupId, tgm.UserId }); // Fixed composite PK

            builder.Property(tgm => tgm.TaskGroupId)
                .IsRequired();

            builder.Property(tgm => tgm.UserId)
                .IsRequired();

            builder.Property(tgm => tgm.JoinedAt)
                .HasDefaultValueSql("CURRENT_DATE")
                .IsRequired();

            builder.HasOne(tgm => tgm.TaskGroup)
                .WithMany(tg => tg.Members)
                .HasForeignKey(tgm => tgm.TaskGroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(tgm => tgm.User)
                .WithMany(u => u.TaskGroupMemberships)
                .HasForeignKey(tgm => tgm.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
