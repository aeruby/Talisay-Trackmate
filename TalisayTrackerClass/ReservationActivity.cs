using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalisayTrackerClass
{
    public class ReservationActivity
    {
        private List<Reservation> reservations;

        public ReservationActivity()
        {
            reservations = new List<Reservation>();
        }

        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public void RemoveReservation(Reservation reservation)
        {
            reservations.Remove(reservation);
        }

        public List<Reservation> GetReservations()
        {
            return reservations;
        }

        public List<Reservation> GetReservationsByDate(DateTime date)
        {
            return reservations.Where(r => r.CheckInDate.Date <= date.Date && r.CheckOutDate.Date >= date.Date).ToList();
        }

        public List<Reservation> GetReservationsByGuestName(string guestName)
        {
            return reservations.Where(r => r.Guest.FullName.ToLower().Contains(guestName.ToLower())).ToList();
        }

        public List<Reservation> GetReservationsByRoomType(RoomType roomType)
        {
            return reservations.Where(r => r.RoomType == roomType).ToList();
        }

        public List<Reservation> GetReservationsByCottageType(CottageType cottageType)
        {
            return reservations.Where(r => r.CottageType == cottageType).ToList();
        }

        public List<Reservation> GetReservationsByAmenity(Amenities amenity)
        {
            return reservations.Where(r => r.Amenities.Contains(amenity)).ToList();
        }
    }
}
