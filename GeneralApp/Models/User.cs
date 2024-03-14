using System.ComponentModel.DataAnnotations;

namespace GeneralApp.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required] 
        public string Password { get; set; }
        [Required] 
        public string Name { get; set; }
        public string Lastname { get; set; }
        [Required] 
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Image { get; set; }
        [Required]
        public bool Active { get; set; } = true;
        [Required] 
        public DateTime Create { get; set; } = DateTime.Now;
    }
}
