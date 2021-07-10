using Microsoft.AspNetCore.Identity;

namespace Identity.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

    }
}