namespace SE491_Project.Data.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        
        public Customer Customer { get; set; }
        
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuests { get; set; }
        public ReservationStatus Status { get; set; } 
        public DateTime ReservationDate { get; set; }
        public string SpecialRequests { get; set; }
        public Payment Payment { get; set; }

        public int TotalNights => (CheckOutDate - CheckInDate).Days;
        public decimal TotalAmount => TotalNights * Room.PricePerNight;
    }

    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        Cancelled,
        Completed
    }
}
