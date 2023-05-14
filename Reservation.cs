namespace TalisayTrackerClass
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public RoomType RoomType { get; set; }
        public CottageType CottageType { get; set; }
        public List<Amenities> Amenity { get; set; }
        public Guest Guest { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaymentDate { get; set; }

        public Reservation(int reservationID, DateTime checkInDate, DateTime checkOutDate,
                           RoomType roomType, CottageType cottageType, List<Amenity> amenities,
                           Guest guest, bool isPaid, DateTime paymentDate)
        {
            ReservationID = reservationID;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            RoomType = roomType;
            CottageType = cottageType;
            Amenity = amenity;
            Guest = guest;
            IsPaid = isPaid;
            PaymentDate = paymentDate;
        }

        public decimal GetTotalAmount()
        {
            decimal totalAmount = 0;

            // Calculate room charges
            totalAmount += RoomType.ChargePerTime * (decimal)(CheckOutDate - CheckInDate).TotalHours;

            // Calculate cottage charges
            totalAmount += CottageType.ChargePerTime * (decimal)(CheckOutDate - CheckInDate).TotalHours;

            // Calculate amenities charges
            foreach (Amenity amenity in Amenities)
            {
                totalAmount += amenity.Charge;
            }

            return totalAmount;
        }

        public void MarkAsPaid()
        {
            IsPaid = true;
            PaymentDate = DateTime.Now;
        }
    }
}
