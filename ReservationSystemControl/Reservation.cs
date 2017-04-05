using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemControl
{
    public class Reservation
    {
        //properties
        public static int maxID;
        public int? ReservationID { get; set; }
        public int ResourceID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string GuestName { get; set; }
        public double TotalPrice { get; set; }
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Initialize a reservation via parameters
        /// </summary>
        /// <param name="resourceID"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="id"></param>
        /// <param name="guestName"></param>
        /// <param name="ccNumber"></param>
        public Reservation(int resourceID, DateTime startDate, DateTime endDate, int? id = null, string guestName = "", string ccNumber = "")
        {
            this.ReservationID = id;
            this.ResourceID = resourceID;
            this.StartDate = startDate;
            if (endDate <= startDate) this.EndDate = this.StartDate.AddDays(1);
            else this.EndDate = endDate;
            this.GuestName = guestName;
            this.CreditCardNumber = ccNumber;
 
        }

        /// <summary>
        /// Initialize a reservation via another reservation instance
        /// </summary>
        /// <param name="reserv"></param>
        public Reservation(Reservation reserv)
        {
            this.ReservationID = reserv.ReservationID;
            this.ResourceID = reserv.ResourceID;
            this.StartDate = reserv.StartDate;
            this.EndDate = reserv.EndDate;
            this.GuestName = reserv.GuestName;
            this.TotalPrice = reserv.TotalPrice;
            this.CreditCardNumber = reserv.CreditCardNumber;
        }

    }
}
