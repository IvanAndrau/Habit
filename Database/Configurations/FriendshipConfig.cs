using HabitTracker.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Database.Configurations
{
    public class FriendshipConfig : IEntityTypeConfiguration<Friendship>
    {
        public void Configure(EntityTypeBuilder<Friendship> builder)
        {
            builder.HasKey(f => new { f.UserId, f.FriendId }); //Composite PK

            builder.Property(f => f.UserId)
                .IsRequired();

            builder.Property(f => f.FriendId)
                .IsRequired();

            builder.Property(f => f.Status)
                .HasConversion<string>()
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(f => f.User)
                .WithMany(u => u.SentFriendRequests)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(f => f.Friend)
                .WithMany(u => u.ReceivedFriendRequests)
                .HasForeignKey(f => f.FriendId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
