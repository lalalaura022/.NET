using Microsoft.AspNetCore.Identity;

namespace ProiectFinal.Models.Entities
{
    public class UserRole : IdentityUserRole<int>
    {
        public Role Role { get; set; }
        public User User { get; set; }  

    }
}
