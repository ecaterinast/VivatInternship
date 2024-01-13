using System.Text.Json.Serialization;

namespace VivatInternship.Backend.Data
{
    public class User
     {
          public int UserId { get; set; }
          public string Username { get; set; }
          [JsonIgnore]
          public string Password { get; set; }
     }
}
