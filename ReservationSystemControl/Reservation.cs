using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemControl
{
    public class Reservation
    {
        public static int maxID;
        public int? ReservationID { get; set; }
        public int ResourceID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string GuestName { get; set; }
        public double TotalPrice { get; set; }
        public string CreditCardNumber { get; set; }

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

    }
}
