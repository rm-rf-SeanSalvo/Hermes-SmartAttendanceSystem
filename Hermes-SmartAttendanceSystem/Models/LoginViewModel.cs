using System.ComponentModel.DataAnnotations;

namespace Hermes_SmartAttendanceSystem.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [EmailAddress(ErrorMessage = "Enter a valid Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
