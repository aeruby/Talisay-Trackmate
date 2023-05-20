using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalisayTrackerClass
{
    public class RoomType
    {
        public string Name { get; set; }
        public decimal OvernightCharge { get; set; }
        public decimal DaytimeCharge { get; set; }

        public RoomType(string name, decimal overnightCharge, decimal daytimeCharge)
        {
            Name = name;
            OvernightCharge = overnightCharge;
            DaytimeCharge = daytimeCharge;
        }

        public decimal GetCharge(DateTime checkIn, DateTime checkOut)
        {
            decimal totalCharge = 0;

            // Calculate overnight charges (3 pm - 12 pm of the next day)
            if (checkIn.Hour >= 15 && checkOut.Hour <= 12 && checkOut.Date == checkIn.Date.AddDays(1))
            {
                totalCharge = OvernightCharge * (decimal)(checkOut.Date - checkIn.Date).TotalDays;
            }
            // Calculate daytime charges (6 am - 12 pm)
            else if (checkIn.Hour >= 6 && checkOut.Hour <= 12 && checkOut.Date == checkIn.Date)
            {
                totalCharge = DaytimeCharge * (decimal)(checkOut.Date - checkIn.Date).TotalDays;
            }

            return totalCharge;
        }
    }

}
