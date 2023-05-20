using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TalisayTrackerClass
{
    public class Amenities
    {
        public string Name { get; set; }
        public decimal CostPerHour { get; set; }

        public ReservationActivity(string name, decimal charge)
        {
            Name = name;
            Charge = charge;
        }

        public decimal CalculateAmenitiesCost(List<Amenities> amenities, int hours)
        {
            decimal totalCost = 0;

            foreach (var amenity in amenities)
            {
                decimal amenityCost = amenity.CostPerHour * hours;
                totalCost += amenityCost;
            }

            return totalCost;
        }
    }

  }
