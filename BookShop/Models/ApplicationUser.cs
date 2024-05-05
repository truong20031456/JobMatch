using Microsoft.AspNetCore.Identity;

namespace BookShop.Models
{
    public class ApplicationUser:IdentityUser<string>
    {
        public required string Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Password { get; set; }
    }
}
