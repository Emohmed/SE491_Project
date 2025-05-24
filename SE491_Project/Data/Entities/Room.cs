using System.ComponentModel.DataAnnotations;

namespace SE491_Project.Data.Entities
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public double PricePerNight { get; set; }
        public RoomStatus Status { get; set; }
        public List<Reservation> Reservations { get; set; } = new();
    }

    public enum RoomStatus
    {
        Available,
        Booked,
        UnderMaintenance
    }

}
