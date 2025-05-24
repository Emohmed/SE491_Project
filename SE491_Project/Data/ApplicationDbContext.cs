using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SE491_Project.Data.Entities;


namespace SE491_Project.Data
{

    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { set; get; } 
        public DbSet<Reservation> Reservations { get; set; }



    }
}
