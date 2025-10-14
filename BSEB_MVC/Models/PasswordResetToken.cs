using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs
{
    public class PasswordResetToken
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //public DateTime Expiration { get; set; }
        //public bool IsUsed { get; set; } = false;
    }
}
