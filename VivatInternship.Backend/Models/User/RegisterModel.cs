using System.ComponentModel.DataAnnotations;

namespace VivatInternship.Backend.Models
{
     public class RegisterModel
     {
          [Required]
          public string Username { get; set; }
          [Required]
          public string Password { get; set; }
          [Required]
          public string ConfirmedPassword { get; set; }
     }
}
