using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace ProiectFinal.Models.Entities
{
    public class User : IdentityUser<int>
    {
        public User() : base() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<UserRole> UserRoles { get; set;  }
    }
}
