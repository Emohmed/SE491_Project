using System.ComponentModel.DataAnnotations;

namespace SE491_Project.Data.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [MaxLength(length: 100)]
        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.Guest;

        public List<Reservation> Reservations { get; set; }= new();
    }

    public enum UserRole
    {
        Guest,  
        Admin    
    }

}

