using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemControl
{
    public class Reservation
    {
        public int? ReservationID { get; set; }
        public int ResourceID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string guestName { get; set; }
        public double TotalPrice { get; set; }
        public string CreditCardNumber { get; set; }

        public Reservation(int resourceID, DateTime startDate, int? id = null, string guestName = "", string ccNumber = "")
        {
            this.ReservationID = id;
            this.ResourceID = resourceID;
            this.StartDate = startDate;
            this.EndDate = startDate.AddDays(1);
            this.guestName = guestName;
            this.CreditCardNumber = ccNumber;
         
        }

    }
}
