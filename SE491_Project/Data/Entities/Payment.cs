namespace SE491_Project.Data.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod Method { get; set; }
        public string TransactionId { get; set; }
        public PaymentStatus Status { get; set; }
    }

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        BankTransfer,
        OnlinePayment
    }

    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Refunded
    }
}
