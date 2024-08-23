using Microsoft.AspNetCore.Identity;

namespace Data.Entities
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public  string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}