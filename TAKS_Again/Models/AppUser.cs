using Microsoft.AspNetCore.Identity;
namespace TAKS_Again.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
