using Microsoft.AspNetCore.Identity;

namespace HabitTracker.DataModels
{
    public class ApplicationUser : IdentityUser
    {
        public string Color { get; set; }
    }
}
