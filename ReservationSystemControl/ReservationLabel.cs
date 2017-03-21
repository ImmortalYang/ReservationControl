using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemControl
{
    public class ReservationLabel: Label
    {
        public Reservation reservation;

        public ReservationLabel(Reservation reserv) : base()
        {
            this.reservation = reserv;
            this.Text = this.ToString();
        }

        public override string ToString()
        {
            if (this.reservation.ReservationID == null) return "";
            else return this.reservation.guestName;
        }
    }
}
