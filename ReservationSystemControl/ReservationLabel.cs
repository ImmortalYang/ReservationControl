using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ReservationSystemControl
{
    public class ReservationLabel: Label
    {
        public Reservation reservation;

        public ReservationLabel(Reservation reserv) : base()
        {
            this.reservation = reserv;
            this.Dock = DockStyle.Fill;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BackColor = Color.CadetBlue;
            this.Name = reserv.ReservationID?.ToString();
            this.Text = this.ToString();
        }

        public override string ToString()
        {
            return this.reservation.ReservationID + " " +this.reservation.GuestName;
        }

    }
}
