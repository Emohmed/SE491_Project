namespace SE491_Project.Data.Entities
{
    public class Room
    {
        public Guid RoomId { get; set; }

        public string Number { get; set; } = string.Empty;  

        public string Type { get; set; }        

        public double PricePerNight { get; set; }  
       

        public RoomStatus Status { get; set; } = RoomStatus.Available;
        

        public List<Reservation> Reservations { get; set; } = [];  // علاقة الحجز
    }

    public enum RoomStatus
    {
        Available,       
        Booked,           
        UnderMaintenance  
    }

 


}
