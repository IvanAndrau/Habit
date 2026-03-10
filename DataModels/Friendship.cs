using HabitTracker.Enums;

namespace HabitTracker.DataModels
{
    public class Friendship
    {
        public Guid UserId { get; set; }
        public Guid FriendId { get; set; }
        public FriendshipStatus Status { get; set; } = FriendshipStatus.Pending;

        public ApplicationUser User { get; set; } = null!;
        public ApplicationUser Friend { get; set; } = null!;
    }
}
