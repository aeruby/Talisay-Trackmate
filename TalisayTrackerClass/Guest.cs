using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalisayTrackerClass
{
    public class Guest
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public List<ReservationActivity> Activities { get; set; }

        public Guest(string name, string contactNumber)
        {
            Name = name;
            ContactNumber = contactNumber;
            Activities = new List<ReservationActivity>();
        }

        public void AddReservationActivity(ReservationActivity activity)
        {
            Activities.Add(activity);
        }

        public void RemoveReservationActivity(ReservationActivity activity)
        {
            Activities.Remove(activity);
        }

        public bool HasUpcomingReservation()
        {
            foreach (ReservationActivity activity in Activities)
            {
                if (activity.Reservation.Status == ReservationStatus.Confirmed && activity.ActivityDate > DateTime.Now)
                {
                    return true;
                }
            }

            return false;
        }
    }

}
