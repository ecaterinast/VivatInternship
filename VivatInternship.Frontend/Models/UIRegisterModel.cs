
using System.ComponentModel.DataAnnotations;

namespace VivatInternship.Frontend.Models
{
    public class UIRegisterModel
     {
          [Display(Prompt = "Enter your username", Name = "Username")]
          [Required(ErrorMessage = "Please, enter your username")]
          [StringLength(20, ErrorMessage = "Username should not exceed 20 characters")]
          public string Username { get; set; }

          [Display(Prompt = "Enter your password", Name = "Password")]
          [DataType(DataType.Password)]
          [Required(ErrorMessage = "Please, enter your password")]
          [StringLength(20, ErrorMessage = "Username should not exceed 20 characters")]
          [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])[a-zA-Z\d]{8,}$", ErrorMessage = "A minimum 8-character password should contain a combination of uppercase and lowercase letters.")]
          public string Password { get; set; }

          [Display(Prompt = "Confirm your password", Name = "Confirmed Password")]
          [DataType(DataType.Password)]
          [Required(ErrorMessage = "Please, confirm your password")]
          public string ConfirmedPassword { get; set; }
     }
}
