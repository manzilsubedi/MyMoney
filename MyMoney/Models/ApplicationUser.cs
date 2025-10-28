using Microsoft.AspNetCore.Identity;

namespace MyMoney.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
 
    }
}
