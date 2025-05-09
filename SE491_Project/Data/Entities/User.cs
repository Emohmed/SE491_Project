namespace SE491_Project.Data.Entities
{
    public class User
    {
        public Guid UserId { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.Guest;

        public List<Reservation> Reservations { get; set; }= [];
    }

    public enum UserRole
    {
        Guest,  
        Admin    
    }

}

