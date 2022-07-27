using Microsoft.AspNetCore.Identity;

namespace NOI_System_API.IdentityAuth
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
