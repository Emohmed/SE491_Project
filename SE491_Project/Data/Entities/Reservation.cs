namespace SE491_Project.Data.Entities
{
    public class Reservation
    {
        public Guid ReservationId { get; set; }

        public Guid RoomId { get; set; }
        public Room Room { get; set; } = new();

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = new();

        public int NumberOfNights => (int)(CheckOutDate.Date - CheckInDate.Date).TotalDays;

        public decimal TotalPrice => NumberOfNights * (Room?.PricePerNight ?? 0);
    }
}

