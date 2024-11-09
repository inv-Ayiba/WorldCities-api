using System.ComponentModel.DataAnnotations;

namespace WorldCities.Server.Data
{
    public class ApiRegisternRequest
    {
        [Required(ErrorMessage = "Email is required.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public required string Password { get; set; }
    }
}
