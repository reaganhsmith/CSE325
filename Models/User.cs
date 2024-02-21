// User.cs
using System.ComponentModel.DataAnnotations;

namespace ServerBlazorEF.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? PasswordHash { get; set; }
    }
}
