using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}