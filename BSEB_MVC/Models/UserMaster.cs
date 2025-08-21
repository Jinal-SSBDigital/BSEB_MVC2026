using System.ComponentModel.DataAnnotations;

namespace BSEB_MVC.Models
{
    public class UserMaster
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Captcha is required")]
        public string Captcha { get; set; }

        public int CaptchaResult { get; set; }
    }
}
