using Microsoft.AspNetCore.Identity;

namespace Sknowed.Persistance.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
